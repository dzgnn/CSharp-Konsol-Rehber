using System;
using System.Runtime.CompilerServices;

namespace Directory // Note: actual namespace depends on the project name.
{
    public class DirectoryFunctions{

        List <Person> persons = new List<Person>();
        public DirectoryFunctions(){
            persons.Add(new Person("Emirhan","Düzgün", "543767"));
            persons.Add(new Person("Enes","Akbal","0541451"));
            persons.Add(new Person("Efe","Düzgün","0531767"));
            persons.Add(new Person("Tuna","Sönmez","0555555"));
            persons.Add(new Person("Engin","Düzgün","0532692"));
        }

        public void add(){

        Console.WriteLine("Kişi adini giriniz : ");
        string name = Console.ReadLine();
        name = name.ToLower();
        Console.WriteLine("Kisi soyadini giriniz : ");
        string surname = Console.ReadLine();
        Console.WriteLine("Kisi no giriniz : ");
        string number = Console.ReadLine();

        Person newperson = new Person(name,surname,number);
        persons.Add(newperson);
        Console.WriteLine(name +" Adli kisi eklenmistir.");      
        }

        public void delete(){
            enbas:
            Console.WriteLine("Kisinin adini giriniz : ");
            string namefordelete = Console.ReadLine();
            namefordelete = namefordelete.ToLower();

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Name == namefordelete)
                {
                    Console.WriteLine(persons[i].Name + " silinmiştir.");
                    persons.RemoveAt(i);

                }

                if (i == persons.Count -1)
                {
                    Console.WriteLine("Böyle bir kişi yok. Tekrar denemek için (1) silme isleminden cikmak icin (0) basiniz");
                    int chooseToValue = int.Parse(Console.ReadLine());
                    if (chooseToValue == 1)
                        goto enbas;
                    else
                        break;
                }
            }

        }

        public void update(){
            enbass:
            Console.WriteLine("Kisinin adini giriniz : ");
            string nameforupdate = Console.ReadLine();
            nameforupdate = nameforupdate.ToLower();
            
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Name == nameforupdate)
                {
                    Console.WriteLine("Yeni adi giriniz : ");
                    string updatedname = Console.ReadLine();
                    persons[i].Name = updatedname;
                }
                if (i == persons.Count -1)
                {
                    Console.WriteLine("Böyle bir kişi yok. Tekrar denemek için (1) guncelleme isleminden cikmak icin (0) basiniz");
                    int chooseToValue = int.Parse(Console.ReadLine());
                    if (chooseToValue == 1)
                        goto enbass;
                    else
                        break;
                    
                }
            }
        }
    
        public void listele()
        {
            
            foreach(var person in persons)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Kisi adi: " + person.Name);
                Console.WriteLine("Kisi soyadi: " + person.Surname);
                Console.WriteLine("Kisi numarasi: " + person.Number);
                Console.WriteLine("----------------------------------------");
            }
        }

        public void search(){
            Console.WriteLine("Aramak istediğiniz kisinin adini yaziniz : ");
            string nameforsearch = Console.ReadLine();
            nameforsearch = nameforsearch.ToLower();

            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Name.Equals(nameforsearch))
                {
                    Console.WriteLine("Kisi Bulundu!");
                    Console.WriteLine("Kisi adi: " +persons[i].Name);
                    Console.WriteLine("Kisi soyadi: " +persons[i].Surname);
                    Console.WriteLine("Kisi numarasi: " +persons[i].Number);

                }
                if (i == persons.Count - 1)
                {
                    Console.WriteLine("Aranan kisi yok. ");
                    break;
                }
            }




        }
    
    
    
    
    
    }

    





}