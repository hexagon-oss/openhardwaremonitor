/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2020 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using Aga.Controls.Tree;
using OpenHardwareMonitor.Hardware;

namespace OpenHardwareMonitor.GUI
{
    public class Node
    {
        private TreeModel _treeModel;
        private Node _parent;
        private NodeCollection _nodes;

        private string _text;
        private Image _image;
        private bool _visible;
        private bool _expanded;

        private TreeModel RootTreeModel()
        {
            Node node = this;
            while (node != null)
            {
                if (node.Model != null)
                    return node.Model;
                node = node._parent;
            }
            return null;
        }

        public Node() : this(string.Empty)
        {
            _expanded = true;
        }

        public Node(string text)
        {
            _text = text;
            _nodes = new NodeCollection(this);
            _visible = true;
            _expanded = true;
        }

        public TreeModel Model
        {
            get
            {
                return _treeModel;
            }
            set
            {
                _treeModel = value;
            }
        }

        public Node Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                if (value != _parent)
                {
                    if (_parent != null)
                        _parent._nodes.Remove(this);
                    if (value != null)
                        value._nodes.Add(this);
                }
            }
        }

        public Node FindNode(string nodeId)
        {
            if (NodeId == nodeId)
            {
                return this;
            }

            foreach (var n in Nodes)
            {
                var ret = n.FindNode(nodeId);
                if (ret != null)
                {
                    return ret;
                }
            }

            return null;
        }

        public virtual string NodeId => Text;

        public Collection<Node> Nodes
        {
            get
            {
                return _nodes;
            }
        }

        public virtual string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text != value)
                {
                    _text = value;
                }
            }
        }

        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (_image != value)
                {
                    _image = value;
                }
            }
        }

        public virtual bool IsExpanded
        {
            get
            {
                return _expanded;
            }
            set
            {
                _expanded = value;
            }
        }

        public virtual bool IsVisible
        {
            get
            {
                return _visible;
            }
            set
            {
                if (value != _visible)
                {
                    _visible = value;
                    TreeModel model = RootTreeModel();
                    if (model != null && _parent != null)
                    {
                        int index = 0;
                        for (int i = 0; i < _parent._nodes.Count; i++)
                        {
                            Node node = _parent._nodes[i];
                            if (node == this)
                                break;
                            if (node.IsVisible || model.ForceVisible)
                                index++;
                        }
                        if (model.ForceVisible)
                        {
                            model.OnNodeChanged(_parent, index, this);
                        }
                        else
                        {
                            if (value)
                                model.OnNodeInserted(_parent, index, this);
                            else
                                model.OnNodeRemoved(_parent, index, this);
                        }
                    }
                    if (IsVisibleChanged != null)
                        IsVisibleChanged(this);
                }
            }
        }

        public override string ToString()
        {
            return $"{Text} ({GetType()})";
        }

        public delegate void NodeEventHandler(Node node);

        public event NodeEventHandler IsVisibleChanged;
        public event NodeEventHandler NodeAdded;
        public event NodeEventHandler NodeRemoved;

        private class NodeCollection : Collection<Node>
        {
            private Node owner;

            public NodeCollection(Node owner)
            {
                this.owner = owner;
            }

            protected override void ClearItems()
            {
                while (this.Count != 0)
                    this.RemoveAt(this.Count - 1);
            }

            protected override void InsertItem(int index, Node item)
            {
                if (item == null)
                    throw new ArgumentNullException("item");

                if (item._parent != owner)
                {
                    if (item._parent != null)
                        item._parent._nodes.Remove(item);
                    item._parent = owner;
                    base.InsertItem(index, item);

                    TreeModel model = owner.RootTreeModel();
                    if (model != null)
                        model.OnStructureChanged(owner);
                    if (owner.NodeAdded != null)
                        owner.NodeAdded(item);
                }
            }

            protected override void RemoveItem(int index)
            {
                Node item = this[index];
                item._parent = null;
                base.RemoveItem(index);

                TreeModel model = owner.RootTreeModel();
                if (model != null)
                    model.OnStructureChanged(owner);
                if (owner.NodeRemoved != null)
                    owner.NodeRemoved(item);
            }

            protected override void SetItem(int index, Node item)
            {
                if (item == null)
                    throw new ArgumentNullException("item");

                RemoveAt(index);
                InsertItem(index, item);
            }
        }
    }
}
