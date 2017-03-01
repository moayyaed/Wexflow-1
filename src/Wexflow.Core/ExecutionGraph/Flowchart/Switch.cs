﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wexflow.Core.ExecutionGraph.Flowchart
{
    public class Switch : Node
    {
        public int SwitchId { get; private set; }
        public Case[] Cases { get; private set; }
        public Node[] Default { get; private set; }

        public Switch(int id, int parentId, int switchId, IEnumerable<Case> cases, IEnumerable<Node> deflt) : base(id, parentId)
        {
            SwitchId = switchId;
            if (cases != null) Cases = cases.ToArray();
            if (deflt != null) Default = deflt.ToArray();
        }
    }
}
