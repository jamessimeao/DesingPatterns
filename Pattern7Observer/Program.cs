using Pattern7Observer;

namespace Pattern7Observer
{
    internal class Program
    {
        public static void Main()
        {
            //BadExample();
            GoodExample();
        }

        public static void BadExample()
        {
            Bad.BadDataSource dataSource = new Bad.BadDataSource();
            Bad.Sheet2 sheet = new Bad.Sheet2();
            Bad.BarChart chart = new Bad.BarChart();

            dataSource.AddDependent(sheet);
            dataSource.AddDependent(chart);

            dataSource.SetValues([5,5,1,10]);
            dataSource.SetValues([1,2,3]);
        }

        public static void GoodExample()
        {
            Good.DataSource dataSource = new();
            Good.Sheet2 sheet2 = new(dataSource);
            Good.BarChart chart = new(dataSource);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);
            dataSource.SetValues([5,5,1,10]);
            dataSource.SetValues([1, 2, 3]);
        }
    }
}