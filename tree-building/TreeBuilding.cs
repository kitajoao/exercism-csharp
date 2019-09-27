using System;
using System.Collections.Generic;
using System.Linq;

public class TreeBuildingRecord
{
    public int ParentId { get; set; }
    public int RecordId { get; set; }
}

public class Tree
{
    public int Id { get; set; }
    public int ParentId { get; set; }
    public List<Tree> Children { get; set; }
    public bool IsLeaf => Children.Count == 0;
}

public static class TreeBuilder
{
    public static Tree BuildTree(IEnumerable<TreeBuildingRecord> records)
    {
        var trees = records.OrderBy(e => e.RecordId)
                           .Select(r => new Tree { Id = r.RecordId, ParentId = r.ParentId }).ToArray();

        if (trees.Length == 0)
        {
            throw new ArgumentException();
        }

        var recordId = 0;
        foreach (var t in trees)
        {
            if ((t.Id == 0 && t.ParentId != 0) ||
                (t.Id != 0 && t.ParentId >= t.Id) ||
                (t.Id != recordId))
            {
                throw new ArgumentException();
            }

            t.Children = trees.Where(n => n.ParentId != n.Id && n.ParentId == recordId).ToList();
            
            recordId++;
        }
        return trees[0];
    }
}