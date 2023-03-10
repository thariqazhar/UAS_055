using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_055
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        string[] queue_array = new string[5];
        public Queues()
        {
            /*Initializing the values of the variables REAR and FRONT to -1 to
             * indicate that the queue is initially empty.*/
            FRONT = -1;
            REAR = -1;
        }
        public void insert(string element)
        {
            /*This statement checks for the overflow condition*/
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /*The following statement checks wheter the queue is empty. If the queue is empty,
             * then the value of the REAR and FRONT variables is set to 0.*/
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /*If REAR is at the last position of the array, then the value of REAR
                 * is set to 0 that corresponds to the first position of the array.*/
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /*If REAR is not at the last position, then its value is
                     * incremented by one.*/
                    REAR = REAR + 1;
            }
            /*Once the position of REAR is determined, the element is added at its proper place,*/
            queue_array[REAR] = element;
        }

        public void insDetail()
        {

            int brng = 1;
            string[] name = new string[brng];
            string[] iden = new string[brng];
            string[] harg = new string[brng];

            for (int i = 0; i < brng; i++)
            {
                Console.Write("Masukkan Nama Barang: ");
                name[i] = Console.ReadLine();
                Console.Write("Masukkan ID Barang: ");
                iden[i] = Console.ReadLine();
                Console.Write("Masukkan Harga Barang: ");
                harg[i] = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Nama\tID\tHarga");
                Console.WriteLine("");
            }

            for (int i = 0; i < brng; i++)
            {
                Console.WriteLine(name[i] + "\t" + iden[i] + "\t" + harg[i]);
            }
        }

        public void remove()
        {
            /*Checks whether the queue is empty.*/
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nJenis barang yang di delete adalah: " +
                queue_array[FRONT] + "\n");
            /*Checks if the queue has one element.*/
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /*If the element to be deleted is at the last position of 
                 the array, then the value of FRONT is set to 0 i.e
                 to the first element of the array.*/
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                {
                    /*FRONT is incremented by one if it's not the first element
                     of array.*/
                    FRONT = FRONT + 1;
                }
            }
        }

        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /*Checks if the queue is empty.*/
            if (FRONT == -1)
            {
                Console.WriteLine("Tidak ada barang\n");
                return;
            }
            Console.WriteLine("\nBarang yang ada adalah...............\n");
            if (FRONT_position <= REAR_position)
            {
                /*Traverses the queue till the last element present in an array.*/
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /*Traverses the queue till the last position of the array.*/
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "     ");
                    FRONT_position++;
                }
                /*Set the FRONT position to the first element of the array.*/
                FRONT_position = 0;
                /*Traverses the array till the last element in the queue*/
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "    ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] strings)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert Barang");
                    Console.WriteLine("2. Delete Barang");
                    Console.WriteLine("3. Display Barang");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4):");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.WriteLine("Masukkan jenis barang: ");
                                string num = Convert.ToString(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                                q.insDetail();
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}

//2. Saya memakai circular queues, agar Indri dapat mengatur data dari barang barang nya sesuai dengan urutan dari kapan barang tersebut datang ke toko indri dari distributor//

//3. Algoritma Queue merupakan struktur data dimana satu data dapat ditambakan diakhir disebut REAR dan data dihapus dari yang paling terakhir disebut FRONT//

//4. a. kedalamannya adalah 4
//   b. 15, 25, 20, 31, 35, 32, 30, 48, 66, 69, 67, 65, 94, 99, 98, 90, 70, 50//