
global using SaveKeyValue = System.Collections.Generic.KeyValuePair<string, string>;
using System.Xml;


namespace Ergasia3.Source.Backend
{
	public sealed class SaveFile
	{
		private const string SaveFileName = "save.xml";
		private const string SaveFileRootNodeName = "config";
		private const string XMLReadError = "Corrupted save file";

		public static List<SaveKeyValue> SavedItems { get; }

		private readonly static XmlDocument doc = new();
		private readonly static XmlNode rootNode;

		static SaveFile()
		{
			try
			{
				doc.Load( SaveFileName );
				rootNode = doc.SelectSingleNode( SaveFileRootNodeName );
				if( rootNode == null )
					throw new XmlException( $"{XMLReadError}: root node != {SaveFileRootNodeName}" );
			}
			catch (Exception)
			{
				rootNode = doc.CreateElement( SaveFileRootNodeName );
				doc.AppendChild( rootNode );
			}

			SavedItems = [];
			foreach( XmlNode child in rootNode.ChildNodes )
			{
				if( child.Attributes == null ||
					child.Attributes.Count != 1 ||
					child.Attributes[ "value" ] == null )
					throw new XmlException( $"{XMLReadError}: child has incorrect structure" );

				SavedItems.Add(new SaveKeyValue(
					child.Name, child.Attributes["value"].Value
				));
			}
		}

		public static void SaveSetting( SaveKeyValue kv )
		{
			// search to see if this key value pair already exists. if so, overwrite it
			for( int i = 0; i < SavedItems.Count; i++ )
			{
				if( SavedItems[i].Key == kv.Key)
				{
					SavedItems.RemoveAt( i );
					break;
				}
			}

			SavedItems.Add( kv );
		}

		public static void PerformSave()
		{
			// we've made sure in the constructor that rootNode can't be null
			rootNode.RemoveAll();

			foreach( SaveKeyValue kv in SavedItems )
			{
				XmlNode newNode = doc.CreateElement( kv.Key );
				XmlAttribute attr = doc.CreateAttribute( "value" );
				attr.Value = kv.Value;
				newNode.Attributes.Append( attr );
				rootNode.AppendChild( newNode );
			}
			doc.Save( SaveFileName );
		}
	}
}
