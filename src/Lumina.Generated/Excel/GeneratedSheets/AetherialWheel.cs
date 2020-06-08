using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetherialWheel", columnHash: 0xfee5acb6 )]
    public class AetherialWheel : IExcelRow
    {
        
        public LazyRow< Item > ItemUnprimed;
        public LazyRow< Item > ItemPrimed;
        public byte Grade;
        public byte HoursRequired;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemUnprimed = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ) );
            ItemPrimed = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 1 ) );
            Grade = parser.ReadColumn< byte >( 2 );
            HoursRequired = parser.ReadColumn< byte >( 3 );
        }
    }
}