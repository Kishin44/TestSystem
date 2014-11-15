using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
    public class DatabaseContainer : IDisposable
    {
        IStorageEngine Engine;

        public ITable<int, StudentRecord> StudentsTable { get; private set; }

        public DatabaseContainer()
            :this("main.stsdb4")
        {           
        }

        public DatabaseContainer(string FileName)
        {
            Engine = STSdb.FromFile(Path.Combine(Environment.CurrentDirectory, FileName));
            StudentsTable = Engine.OpenXTable<int, StudentRecord>("Student Record");
        }

        public void Commit()
        {
            Engine.Commit();
        }
        public void Dispose()
        {
            Engine.Commit();
            Engine.Dispose();
        }

        public IEnumerable<StudentRecord> GetStudents()
        {
            foreach (var item in StudentsTable)
            {
                yield return item.Value;
            }
        }
    }
}
