using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;

public enum MonsterType
{
    Beast,
    Aquatic,
    Reptide,
    Bird,
    Bug,
    Plant

}
[CreateAssetMenu(menuName = "Game-Jam-Shit/MonsterSO")]
public class MonsterCardSOData : CardSOData
{
    public int Health;
    public MonsterType Type;
    public int NormalAttackDamage;
    public int SkillDamage;
    public SkeletonDataAsset SkeletonAsset;

    //! Cannot serialize var??
    
}
