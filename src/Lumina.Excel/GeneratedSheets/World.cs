// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "World", columnHash: 0xd4d62b80 )]
    public partial class World : ExcelRow
    {
        
        public SeString Name { get; set; }
        public byte UserType { get; set; }
        public LazyRow< WorldDCGroupType > DataCenter { get; set; }
        public bool IsPublic { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            UserType = parser.ReadColumn< byte >( 1 );
            DataCenter = new LazyRow< WorldDCGroupType >( gameData, parser.ReadColumn< byte >( 2 ), language );
            IsPublic = parser.ReadColumn< bool >( 3 );
        }
    }
}