using FluentValidation.Results;
using Round2.Logic;
using System;
using System.Collections.Generic;
using System.IO;

namespace Round2
{
    public class UiLogic
    {
        public void Run()
        {
            Console.WriteLine("Run");
            var listRounds = ReaderFile();
            var logicRound = new RoundLogic();
            var rounds = new List<Round>();

            Round tempRound;

            foreach (var item in listRounds)
            {
                tempRound = logicRound.Create(item[0], item[1],item[2], out IEnumerable<ValidationFailure> listError);
                if (tempRound != null)
                    rounds.Add(tempRound);

                foreach (var error in listError)
                {
                     Console.WriteLine($"{error.ErrorMessage} coord: x= {item[0]} y={item[1]} radius={item[2]}");
                }   
            }
        }

        private IEnumerable<IList<double>> ReaderFile()
        {
            var listData = new List<List<double>>();
            using (var file = new StreamReader("TextFile1.txt"))
            {
                try
                {
                    string[] lines;

                    while (!file.EndOfStream)
                    {
                        lines = file.ReadLine().Split(' ');
                        if (lines.Length == 3)
                        {
                            double.TryParse(lines[0], out double x);
                            double.TryParse(lines[1], out double y);
                            double.TryParse(lines[2], out double radius);

                            listData.Add(new List<double> { x, y, radius });
                        } 
                    }    
                }
                catch
                {
                    Console.WriteLine("Data error in the file");
                }
            }
            return listData;
        }
    }
}
