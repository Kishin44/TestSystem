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
        private IStorageEngine Engine;

        public ITable<int, Student> Students { get; private set; }
        public ITable<int, Discipline> Disciplines { get; private set; }
        public ITable<int, Chapter> Chapters { get; private set; }
        public ITable<int, Question> Questions { get; private set; }

        public DatabaseContainer(string FileName)
        {
            Engine = STSdb.FromFile(Path.Combine(Environment.CurrentDirectory, FileName));
            Students = Engine.OpenXTable<int, Student>("Student");
            Disciplines = Engine.OpenXTable<int, Discipline>("Disciplines");
            Chapters = Engine.OpenXTable<int, Chapter>("Chapters");
            Questions = Engine.OpenXTable<int, Question>("Questions");
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
    }
}
