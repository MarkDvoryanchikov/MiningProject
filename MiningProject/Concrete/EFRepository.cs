using MiningProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiningProject.Concrete
{

    class EFRepository
    {
        private EFDbContext context = new EFDbContext();


        public void SaveChanges()
        {
            context.SaveChanges();
        }




        // Основные адачи
        public IEnumerable<MyTask> MyTasks
        {
            get { return context.MyTasks.ToList(); }
        }

        public void AddMyTask(MyTask mytask)
        {
            if (mytask.PK_Task == 0)
            {
                context.MyTasks.Add(mytask);
            }
            else
            {
                var temp = context.MyTasks.Find(mytask.PK_Task);
                if (temp != null)
                {
                    temp.TaskName = mytask.TaskName;
                    temp.Time = mytask.Time;
                }
            }
            SaveChanges();
        }

        public void RemoveMyTask(MyTask mytask)
        {
            context.MyTasks.Remove(mytask);
            SaveChanges();
        }




        // Угольные пласты
        public IEnumerable<Layer> Layers
        {
            get { return context.Layers.ToList(); }
        }

        public void AddLayer(Layer layer)
        {
            if (layer.PK_Layer == 0)
            {
                context.Layers.Add(layer);
            }
            else
            {
                var temp = context.Layers.Find(layer.PK_Layer);
                if (temp != null)
                {
                    temp.MyTask = layer.MyTask;
                    temp.Numberlayer = layer.Numberlayer;
                    temp.NameLayer = layer.NameLayer;
                    temp.C1 = layer.C1;
                    temp.C2 = layer.C2;
                    temp.C3 = layer.C3;
                    temp.C4 = layer.C4;
                    temp.C5 = layer.C5;
                    temp.C6 = layer.C6;
                    temp.C7 = layer.C7;
                    temp.C8 = layer.C8;
                    temp.C9 = layer.C9;
                    temp.C10 = layer.C10;
                    temp.C11 = layer.C11;
                    temp.C12 = layer.C12;
                    temp.C13 = layer.C13;
                    temp.C14 = layer.C14;
                }
            }
            SaveChanges();
        }

        public void RemoveLayer(Layer layer)
        {
            context.Layers.Remove(layer);
            SaveChanges();
        }


        // Расчеты
        public IEnumerable<Calc> Calcs
        {
            get { return context.Calcs.ToList(); }
        }

        public void AddCalc(Calc calc)
        {
            if (calc.PK_Calc == 0)
            {
                context.Calcs.Add(calc);
            }
            else
            {
                var temp = context.Calcs.Find(calc.PK_Calc);
                if (temp != null)
                {
                    temp.MyTask = calc.MyTask;
                    temp.NameCalc = calc.NameCalc;
                    temp.Participation = calc.Participation;
                }
            }
            SaveChanges();
        }

        public void RemoveCalc(Calc calc)
        {
            context.Calcs.Remove(calc);
            SaveChanges();
        }


        // Расчет по платстам / таблица для построения кривых обогатимости
        public IEnumerable<LayersCalculation> LayersCalculations
        {
            get { return context.LayersCaculations.ToList(); }
        }

        public void AddLayersCalculations(LayersCalculation ls)
        {
            if (ls.PK_LayersCalculation == 0)
            {
                context.LayersCaculations.Add(ls);
            }
            else
            {
                var temp = context.LayersCaculations.Find(ls.PK_LayersCalculation);
                if (temp != null)
                {
                    temp.Calc = ls.Calc;
                    temp.Class = ls.Class;
                    temp.C1 = ls.C1;
                    temp.C2 = ls.C2;
                    temp.C3 = ls.C3;
                    temp.C4 = ls.C4;
                    temp.C5 = ls.C5;
                    temp.C6 = ls.C6;
                }
            }
            SaveChanges();
        }

        public void RemoveLayersCalculation(LayersCalculation ls)
        {
            context.LayersCaculations.Remove(ls);
            SaveChanges();
        }
    }
}
