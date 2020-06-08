using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventAction", columnHash: 0x1c60d673 )]
    public class EventAction : IExcelRow
    {
        
        public string Name;
        public ushort Icon;
        public byte CastTime;
        public LazyRow< ActionTimeline >[] Animation;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< ushort >( 1 );
            CastTime = parser.ReadColumn< byte >( 2 );
            for( var i = 0; i < 3; i++ )
                Animation[ i ] = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 3 + i ) );
        }
    }
}