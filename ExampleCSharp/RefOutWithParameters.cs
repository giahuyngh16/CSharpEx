using System;

namespace ExampleCSharp
{
    public static class RefOutWithParameters
    {
        public static void OutTryGet()
        {
            var exampleOut = new OutWithParameters();
            int id = 1;
            while (id > 0)
            {
                Console.Write("Input Id to get user: ");
                id = int.Parse(Console.ReadLine());
                exampleOut.GetUserById(id);
                Console.WriteLine();
            }
        }

        public static void RefValueType()
        {
            var exampleRefValueType = new RefWithParameters();
            int num = 1;
            Console.WriteLine("Number before reset: " + num);

            exampleRefValueType.IncrementWithoutRef(num);
            Console.WriteLine("Number after reset without ref: " + num);

            exampleRefValueType.Increment(ref num);
            Console.WriteLine("Number after reset: " + num);
        }

        public static void RefReferenceType()
        {
            var exampleRefValueType = new RefWithParameters();
            var user = UserModel.users[0];
            Console.WriteLine("User Name before reset: " + user.Name);

            exampleRefValueType.ResetUserNameToDefaultWithoutRef(user);
            Console.WriteLine("User Name after reset without ref: " + user.Name);
            Console.WriteLine("User Name in static list after reset without ref: " + UserModel.users[0].Name);

            exampleRefValueType.ResetUserNameToDefault(ref user);
            Console.WriteLine("User Name after reset: " + user.Name);
            Console.WriteLine("User Name in static list after reset: " + UserModel.users[0].Name);
        }

        public static void Resize()
        {
            var list = new int[] { 1, 2, 3 };

            foreach (var item in list) // result: 123
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Array.Resize(ref list, list.Length - 1);

            foreach (var item in list) // result: 12
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Array.Resize(ref list, list.Length + 1);

            foreach (var item in list) // result: 12?
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

    public class RefWithParameters
    {
        public void Increment(ref int num)
        {
            num++;
        }

        public void IncrementWithoutRef(int num)
        {
            num++;
        }

        public void ResetUserNameToDefault(ref UserModel user)
        {
            user.Name = "username";
        }

        public void ResetUserNameToDefaultWithoutRef(UserModel user)
        {
            user.Name = "username without ref";
        }
    }


    public class OutWithParameters
    {
        public UserModel GetUserById(int id)
        {
            var outWithParams = new OutWithParameters<UserModel>();

            bool isExistedUser = outWithParams.TryGetValue(UserModel.users, id, out var user);

            if (isExistedUser)
                Console.WriteLine($"User name: {user.Name}");
            else
                Console.WriteLine("Cannot find the user by Id");

            return user;
        }
    }

    public class OutWithParameters<T>
    {
        private T[] entries;

        public bool TryGetValue(T[] entries, int key, out T value)
        {
            this.entries = entries;
            var i = FindByKey(key);

            if (i>= 0)
            {
                value = this.entries[i];
                return true;
            }

            value = default(T);
            return false;
        }

        private int FindByKey(int key)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                var propertyId = entries[i].GetType().GetProperty("Id");
                if (propertyId.GetValue(entries[i]).Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }
    }

    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static UserModel[] users = new UserModel[]
            {
                new UserModel{Id = 1, Name = "Truc.Nguyen"},
                new UserModel{Id = 2, Name = "Huy.NguyenGia"},
                new UserModel{Id = 3, Name = "Trung.Tran"},
                new UserModel{Id = 4, Name = "Din.Ho"},
            };
    }
}
