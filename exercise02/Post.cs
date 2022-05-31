using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise02
{
    internal class Post
    {

        private string _title;
        private string _description;
        private int _votesCount;
        

        public DateTime Date { get; set; }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int UpVote()
        {
            _votesCount++;
            return _votesCount;
        }

        public int DownVote()
        {
            _votesCount--;
            return _votesCount;
        }

        public int TotalVotes()
        {
            return _votesCount;
        }

    }
}
