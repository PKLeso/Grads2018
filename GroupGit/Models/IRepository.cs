using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupGit.Models
{
    interface IRepository
    {
        void HelloGit();
        int GetGitID();

        string GetGitRepository();
    }
}
