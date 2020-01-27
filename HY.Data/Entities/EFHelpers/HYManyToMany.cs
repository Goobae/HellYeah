namespace HY.Data.Entities.EFHelpers
{
    public class HYManyToMany<T,D> 
        where T:HYBase
        where D:HYBase
    {
        public int ChildId { get; set; }
        public T Child { get; set; }

        public int ParentId { get; set; }
        public D Parent { get; set; }
    }
}
