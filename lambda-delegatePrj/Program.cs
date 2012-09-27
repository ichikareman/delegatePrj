using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lambda_delegatePrj
{
    class Program
    {
        static void Main(string[] args)
        {
            //user.Add("");
            //x.Add();
            Repository<User> repoUser = new Repository<User>();

            repoUser.Add(new User() { Id = 1, Name = "user1" });
            repoUser.Add(new User() { Id = repoUser.GetLastIn().Id+1, Name = "user2" });
            repoUser.Add(new User() { Id = repoUser.GetLastIn().Id+1, Name = "user3" });
            repoUser.Add(new User() { Id = repoUser.GetLastIn().Id+1, Name = "user4" });

            var list = repoUser.Query(item => item.Id % 2 != 0);
            
            foreach (var user in list)
            {
                Console.WriteLine(user.Id + ":" + user.Name);
            }

            Console.ReadKey();

        }
    }



}
