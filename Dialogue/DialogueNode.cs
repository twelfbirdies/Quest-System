using System;
using System.Collections.Generic;
using UnityEngine;
namespace RPG.Dialogue {

[Serializable]
public class DialogueNode
{
   public String uniqueID;
   public String text;
   public List<String> children = new List<string>();
   public Rect rect = new Rect(0,0,200,100);

}}
