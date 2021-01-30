using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Set
{
    public class SuperSet<T> : IEnumerable
    {
        private readonly List<T> items = new List<T>();
        public int Count => items.Count;
        public SuperSet() { }

        public SuperSet(T item)
        {
            items.Add(item);
        }

        public SuperSet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        public void Add(T item)
        {
            //LINQ

            if (items.Contains(item))
            {
                return;
            }

            //Manual Add

            //foreach (var i in items)
            //{
            //    if (i.Equals(item))
            //    {
            //        return
            //    }
            //}
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public SuperSet<T> Union(SuperSet<T> set)
        {
            //LINQ

            return new SuperSet<T>(items.Union(set.items));

            //Manual Union

            //SuperSet<T> result = new SuperSet<T>();

            //foreach (var item in items)
            //{
            //    result.Add(item);
            //}

            //foreach (var item in set.items)
            //{
            //    result.Add(item);
            //}
        }

        public SuperSet<T> Intersection(SuperSet<T> set)
        {
            //LINQ

            return new SuperSet<T>(set.items.Intersect<T>(items));

            //Manual Intersection

            //var result = new SuperSet<T>();
            //SuperSet<T> big;
            //SuperSet<T> small;

            //if (Count >= set.Count)
            //{
            //    big = this;
            //    small = set;
            //}
            //else
            //{
            //    big = set;
            //    small = this;
            //}
            //foreach (var item1 in small.items)
            //{
            //    foreach (var item2 in big.items)
            //    {
            //        if (item1.Equals(item2))
            //        {
            //            result.Add(item1);
            //            break;
            //        }
            //    }
            //}
        }

        public SuperSet<T> Difference(SuperSet<T> set)
        {
            //LINQ

            return new SuperSet<T>(items.Except(set.items));

            //Manual Difference

            //var result = new SuperSet<T>(items);

            //foreach(var item in set.items)
            //{
            //    result.Remove(item);
            //}
            
            //return result;
        }

        public bool Subset(SuperSet<T> set)
        {
            //LINQ
            return items.All(i => set.items.Contains(i));

            //Manual Subset

            //foreach(var item1 in items)
            //{
            //    var equals = false;

            //    foreach(var item2 in set.items)
            //    {
            //        if(item1.Equals(item2))
            //        {
            //            equals = true;
            //            break;
            //        }
            //    }

            //    if(!equals)
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }

        public SuperSet<T> SymetricDifference(SuperSet<T> set)
        {
            //LINQ

            return new SuperSet<T>(items.Except(set.items).Union(set.items.Except(items)));

            //Manual Difference

            //var result = new SuperSet<T>();

            //foreach (var item1 in items)
            //{
            //    var equals = false;

            //    foreach (var item2 in set.items)
            //    {
            //        if(item1.Equals(item2))
            //        {
            //            equals = true;
            //            break;
            //        }
            //    }

            //    if(equals == false)
            //    {
            //        result.Add(item1);
            //    }
            //}

            //foreach (var item1 in set.items)
            //{
            //    var equals = false;

            //    foreach (var item2 in items)
            //    {
            //        if (item1.Equals(item2))
            //        {
            //            equals = true;
            //            break;
            //        }
            //    }

            //    if (equals == false)
            //    {
            //        result.Add(item1);
            //    }
            //}

            //return result;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
