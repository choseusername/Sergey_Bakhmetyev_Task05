using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLibrary
{
    /*
   * Задание 1
На основе класса User (см. задание 1 из предыдущей темы), создать класс Employee, описывающий сотрудника фирмы.
В дополнение к полям пользователя добавить свойства «стаж работы» и «должность».
Обеспечить нахождение класса в заведомо корректном состоянии.  Подумать над новыми свойствами с точки зрения использования этого класса в будущем.
*/
    public class Employee: User
    {
        public Employee(string lastName, string firstName, string middleName, DateTime birthDate):
            base(lastName, firstName, middleName, birthDate)
        {
        }

        Employee(string lastName, string firstName, DateTime birthDate):
            base(lastName, firstName, birthDate)
        {

        }
    }
}
