using System.Collections.Generic;

namespace Back_end.Helpers
{
    public class Paginate<T>
    {
        public List<T> Datas { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }

        public Paginate(List<T> datas, int currentPage, int totalPage)
        {
            Datas = datas;
            CurrentPage = currentPage;
            TotalPage = totalPage;
        }

        public bool Previous
        {
            get
            {
                return CurrentPage > 1;
            }
        }
        public bool Next
        {
            get
            {
                return CurrentPage < TotalPage;
            }
        }
    }
}
