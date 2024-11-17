# Patika+ Week8 Empty MVC Uygulaması
Merhaba,
Bu proje C# ile Patika+ 8.hafta MVC uygulaması için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- Class yapısı
- MVC yapısını anlamak


## İstenilen Görev
Pratik - Asp.Net Core Empty

Bu pratikte, bir ASP.NET Core Empty projesi oluşturup, projedeki yapıları MVC tasarım desenine uygun olarak yapılandırmanız beklenmektedir.

Aşağıdaki yapıların eklenmesini ve konfigüre edilmesini sağlayınız:

 1. Controllers Klasörü:

   - `Controllers` adında bir klasör oluşturun.

 2. Models Klasörü:

   - `Models` adında bir klasör oluşturun.

   

Aşağıdaki görevleri yerine getirin:

1. Tabloyu Tanımlayın:

   `Student` ve `Class` isimli iki sınıf oluşturun. Her bir sınıf için uygun veri türlerini kullanarak C# sınıflarını tanımlayın.

2. Veri Listelemesi:

   ![fqZCLaJ-xxxxxxxxxxx](https://github.com/user-attachments/assets/e4fa8699-8b04-446a-afe9-dea8e240bc1b)


3. LINQ Sorgusu:

   Öğrenciler ve sınıflar arasında `group join` işlemi yaparak, her sınıfın altında o sınıfa ait olan öğrencilerin listelendiği bir sonuç elde edin. Sonuçları sınıf adıyla birlikte, o sınıfa ait öğrencilerin isimleriyle birlikte ekrana yazdıran bir LINQ sorgusu yazın.


## Kod
```csharp
    static void Main(string[] args)
    {
        // Yapıcı method'u olan class'dan list tanımlama
        List<Students> students = new List<Students>
        {
            new Students(1, "Ali", 1),
            new Students(2, "Ayşe",2),
            new Students(3, "Mehmet",1),
            new Students(4, "Fatma",3),
            new Students(5, "Ahmet",2),
        };

        // Yapıcı methodu olmayan class'dan list tanımlama
        List<Classes> classes = new List<Classes>()
        {
            new Classes{ClassId = 1, ClassName ="Matematik"},
            new Classes{ClassId = 2, ClassName ="Türkçe"},
            new Classes{ClassId = 3, ClassName ="Kimya"},
        };

        var query = classes.GroupJoin(students,
                                      classes => classes.ClassId,
                                      student => student.ClassId,
                                      (classes,student) => new
                                      {
                                          ClassName = classes.ClassName,
                                          StudentName = student.Select(student => student.StudentName)
                                      });


        foreach(var c in query)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sınıf: "+c.ClassName);
            Console.ResetColor();
            foreach(var s in c.StudentName)
            {
                Console.WriteLine("Öğrenci: " + s);
            }
            Console.WriteLine("*******************\r\n");

        }

    }


    // Student Class
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }

        public Students(int studentId, string studentName, int classId)
        {
            StudentId = studentId;
            StudentName = studentName;
            ClassId = classId;
        }
    }

    // Classes Class
    public class Classes
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
```

## Uygulama Çıktısı: 
![resim](https://github.com/user-attachments/assets/c9e6a924-8130-437f-8cde-30404ea1f272)






