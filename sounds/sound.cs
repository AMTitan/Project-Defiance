﻿using UnityEngine;

namespace sounds
{
    [System.Serializable]
    public class sound 
    {

        public string name;
    
        public AudioClip clip;

        [Range(0f, 1f)]
        public float volume;
        [Range(0.1f, 3f)]
        public float pitch;
    }
}
