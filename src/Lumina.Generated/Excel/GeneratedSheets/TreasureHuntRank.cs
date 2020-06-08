using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TreasureHuntRank", columnHash: 0x3997d502 )]
    public class TreasureHuntRank : IExcelRow
    {
        
        public byte Unknown0;
        public uint Icon;
        public LazyRow< Item > ItemName;
        public LazyRow< EventItem > KeyItemName;
        public LazyRow< EventItem > InstanceMap;
        public byte MaxPartySize;
        public byte MinPartySize;
        public ushort Unknown7;
        public bool Unknown8;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            ItemName = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 2 ) );
            KeyItemName = new LazyRow< EventItem >( lumina, parser.ReadColumn< int >( 3 ) );
            InstanceMap = new LazyRow< EventItem >( lumina, parser.ReadColumn< int >( 4 ) );
            MaxPartySize = parser.ReadColumn< byte >( 5 );
            MinPartySize = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
        }
    }
}