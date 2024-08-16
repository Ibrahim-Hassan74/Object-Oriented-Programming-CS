using static System.Console;
using System.Reflection;
namespace maincs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("MemberInfo");
            MemberInfo[] members = typeof(BankAccount).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MemberInfo member in members)
                WriteLine(member);
            WriteLine("\n\n-----------------------------------------------------------------\n");
            WriteLine("FieldInfo");
            FieldInfo[] fields = typeof(BankAccount).GetFields();
            foreach (MemberInfo field in fields)
                WriteLine(field);
            WriteLine("\n\n-----------------------------------------------------------------\n");
            WriteLine("PropertyInfo");
            PropertyInfo[] propertys = typeof(BankAccount).GetProperties();
            foreach (MemberInfo property in propertys)
                WriteLine(property);

            WriteLine("\n\n-----------------------------------------------------------------\n");
            WriteLine("EventInfo");
            EventInfo[] events = typeof(BankAccount).GetEvents();
            foreach (MemberInfo e in events)
                WriteLine(e);
            WriteLine("\n\n-----------------------------------------------------------------\n");
            WriteLine("ConstructorInfo");
            ConstructorInfo[] ctors = typeof(BankAccount).GetConstructors();
            foreach (MemberInfo ctor in ctors)
                WriteLine(ctor);
            WriteLine("\n\n-----------------------------------------------------------------\n");

            WriteLine("Get Member by Name");

            MemberInfo[] memberss = typeof(BankAccount).GetMember(".ctor");
            foreach (MemberInfo m in memberss)
                WriteLine(m);

            WriteLine("\n\n-----------------------------------------------------------------\n");

            var account = new BankAccount("I123","Ibrahim",1200m);
            Type t = typeof(BankAccount);
            // account.Deposite(100)

            Type[] paramentersTypes = { typeof(decimal) };
            MethodInfo method = t.GetMethod("Deposit");
            method.Invoke(account, new object[] { 500m });
            WriteLine(account);


        }

        private static void B_OnNegativeBalance(object? sender, EventArgs e) => WriteLine("Negative Balance !!!!");
    }
}
