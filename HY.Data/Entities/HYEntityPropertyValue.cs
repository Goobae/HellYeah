namespace HY.Data.Entities
{
    public class HYEntityPropertyValue : HYBase
    {
        public HYEntityProperty EntityProperty { get; set; }
        public int EntityPropertyId { get; set; }
        public string Value { get; set; }
    }
}
