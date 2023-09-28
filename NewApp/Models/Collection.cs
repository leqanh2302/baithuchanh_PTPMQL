using System.Collections;
using NewApp.Models;
ArrayList arrList = new ArrayList();
for (int i = 0; i<2; i++)
{
    Student std = new Student();
    std.NhapThongTin();
    arrList.Add(std);
}
foreach(Student std in stdList)
{

}
