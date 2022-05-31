using System;

namespace exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var post = new Post();
            

            while (true)
            {
                Console.WriteLine("Type 'up-vote' or 'down-vote' to rate this post");
                var input = Console.ReadLine();

                if (input == "up-vote")
                {
                    post.UpVote();
                }
                else if (input == "down-vote")
                {
                    post.DownVote();
                }
                else if (string.IsNullOrWhiteSpace(input) || input == "quit")
                {
                    break;
                }
                
            }
            Console.WriteLine(post.TotalVotes());
            
        }
    }
}

