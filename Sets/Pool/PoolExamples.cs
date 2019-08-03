using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureOverview.Sets.Pool
{
    public class PoolExample
    { 
        private static Random random = new Random();
        public void Run()
        {
            var pools = new Dictionary<PoolType, HashSet<int>>()
            {
                {PoolType.Competition, new HashSet<int>()},
                {PoolType.Kids, new HashSet<int>()},
                {PoolType.Recreation, new HashSet<int>()},
                {PoolType.Thermal, new HashSet<int>()},
            };

            for(int i = 1; i < 100; i++)
            {
                foreach(KeyValuePair<PoolType, HashSet<int>> pool in pools)
                {
                    if (GetRandomBoolean())
                      pool.Value.Add(i);
                }
            }

            Console.WriteLine("Number of visitors by a pool:");
            foreach (KeyValuePair<PoolType, HashSet<int>> pool in pools)
            {
                Console.WriteLine($"{pool.Key}: {pool.Value.Count} visitors.");
            }

            PoolType mostVisitedPool = pools
                .OrderByDescending(x => x.Value.Count)
                .Select(x => x.Key)
                .FirstOrDefault();
            Console.WriteLine($"The {mostVisitedPool} pool was the most visited pool, with {mostVisitedPool}.");
        
            var visitedAtLeastOnePool = new HashSet<int> ();
            visitedAtLeastOnePool.UnionWith(pools[PoolType.Competition]);
            visitedAtLeastOnePool.UnionWith(pools[PoolType.Kids]);
            visitedAtLeastOnePool.UnionWith(pools[PoolType.Recreation]);
            visitedAtLeastOnePool.UnionWith(pools[PoolType.Thermal]);

            var visitedAlPools = new HashSet<int> (pools[PoolType.Competition]);
            visitedAlPools.IntersectWith(pools[PoolType.Kids]);
            visitedAlPools.IntersectWith(pools[PoolType.Recreation]);
            visitedAlPools.IntersectWith(pools[PoolType.Thermal]);

            Console.WriteLine($"{visitedAtLeastOnePool.Count} people visited at least one pool.");
            Console.WriteLine($"{visitedAlPools.Count} people visited all pools.");
        }

        private static bool GetRandomBoolean()
        {
            return random.Next(2) == 1;
        }
    }

    public enum PoolType
    {
        Recreation,
        Competition,
        Thermal,
        Kids
    }
}