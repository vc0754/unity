# Unity 学习笔记

## 2D

[官方2D路线图](https://unity.com/cn/roadmap/unity-platform/2d)

## 教程

* [官方教程] [Ruby's Adventure：2D 初学者](https://learn.unity.com/project/ruby-s-adventure-2d-chu-xue-zhe)

  项目 ● 初学者 ● 14 小时 20 分钟 ● 知识点 29 ● 类型 RPG
  
  ★ 当前阅读进度
  [精灵动画 - 1.Animator](https://learn.unity.com/tutorial/jing-ling-dong-hua?uv=2020.3&projectId=5facf921edbc2a2003a58d3a#6073def7edbc2a04020b22a0)

  ---

* [官方教程] [创作者套件：RPG](https://learn.unity.com/project/chuang-zuo-zhe-tao-jian-rpg?uv=2020.3)

  项目 ● 初学者 ● 1 小时 10 分钟 ● 知识点 14 ● 类型 RPG

  ★ 当前阅读进度
  [填充你的事解 - 4.添加 NPC 对话](https://learn.unity.com/tutorial/tian-chong-ni-de-shi-jie?uv=2020.3&projectId=5facfb7dedbc2a001f53383c#6073f4b4edbc2a001f576ac6)

  ---

* [官方教程] [平台游戏 Microgame](https://learn.unity.com/project/ping-tai-you-xi-microgame?uv=2019.3)

  模板项目 ● 知识点 9 ● 类型 横版

  此 Microgame 模板是你可以修改和自定义的经典 2D 平台游戏。在学习 Unity 基础知识的同时，请了解创意修改 (Creative Mods)，这样你就可以调整已有项目并添加你自己的关卡。正在从 Unity Hub 的 Learn 选项卡中查看项目？单击 Download Project > Open Project 即可在 Unity 中自动打开项目。正在从 Unity Learn 网站中查看项目？只需转到 Unity Hub 中的 Learn 选项卡，然后搜索此 Microgame，或通过下面的 Asset Store 链接手动将其导入。

  ★ 当前阅读进度
  [2D 平台游戏修改：有色世界 - 深入学习](https://learn.unity.com/tutorial/2d-ping-tai-you-xi-xiu-gai-you-se-shi-jie?uv=2019.3&projectId=5facf6bcedbc2a043f509bd7#)

---

## Packages

* Cinemachine

  [Cinemachine](https://learn.unity.com/tutorial/cinemachine#)

  [摄像机 - Cinemachine](https://learn.unity.com/tutorial/she-xiang-ji-cinemachine?projectId=5facf921edbc2a2003a58d3a#)

---

## Resources

* 官方资源包
  * [Premium 2D Characters](https://assetstore.unity.com/packages/2d/characters/premium-2d-characters-98327)

* 其他资源包
  * [资源包网站](http://www.zyb99.cn/241)
  * [像素小人制作工具（付费）](https://booth.pm/zh-cn/items/2490778)
  * [indienova 独立游戏](https://indienova.com/sp/gameDevResource)
  * [像素画高级教程：8方向游戏角色](https://32comic.com/2020/08/13/%e5%83%8f%e7%b4%a0%e7%94%bb%e9%ab%98%e7%ba%a7%e6%95%99%e7%a8%8b%ef%bc%9a8%e6%96%b9%e5%90%91%e6%b8%b8%e6%88%8f%e8%a7%92%e8%89%b2/)
  * [百度贴吧 - 最经典的十款 FC 红白机 RPG 游戏](http://tieba.baidu.com/p/6841888066)

---

## Manual

* [UnityWebRequest](https://docs.unity3d.com/cn/2020.3/Manual/UnityWebRequest.html)
* [瓦片地图渲染器 (Tilemap Renderer)](https://docs.unity3d.com/cn/2020.3/Manual/class-TilemapRenderer.html)

---

## 哔哩哔哩

* [【游戏开发】Unity 2D 角色控制逻辑教程（移动，翻滚，瞬移）](https://www.bilibili.com/video/av94823619/)
* [M_Studio - 3DRPG核心教程每周五晚6:30更新！各平台请看公告](https://space.bilibili.com/370283072/)
* [谜样神君 - RPG Marker](https://space.bilibili.com/2394867)
* [哔哩哔哩 搜索 tile地图](https://search.bilibili.com/all?keyword=tile%20地图)

---

## 动画笔记
1. Animator 组件
2. Animator Controller
3. 通过 Animation 窗口创建 Animation Clip
4. 通过 Animator 窗口编辑 Animator Controller

---

## 解决抖动的根本原因
移动`刚体`本身而不是游戏对象`transform`

---

## Unity Scripts

角色控制脚本，记录以强化记忆

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;

    public float timeInvincible = 2.0f;
    float invincibleTimer;
    bool isInvincible;

    public int maxHP = 5;
    public int HP { get { return currentHP; }}
    int currentHP;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    Vector2 direction = new Vector2(1, 0);
    


    // Start is called before the first frame update
    void Start()
    {
        // 更改每秒渲染帧数
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 36;
        
        rigidbody2d = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Vector2 position = transform.position;
        // position.x = position.x + speed * horizontal * Time.deltaTime;
        // position.y = position.y + speed * vertical * Time.deltaTime;
        // transform.position = position;

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0) isInvincible = false;
        }

        Vector2 move = new Vector2(horizontal, vertical);
        if(!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            direction.Set(move.x, move.y);
            direction.Normalize();
        }
        
        animator.SetFloat("Move X", direction.x);
        animator.SetFloat("Move Y", direction.y);
        animator.SetFloat("Speed", move.magnitude);

        // animator.SetFloat("Move X", horizontal);
        // animator.SetFloat("Move Y", vertical);
    }
    
    // Unity 还有另一个名为 FixedUpdate 的函数，只要你想直接影响物理组件或对象（例如刚体），就需要使用该函数。
    // FixedUpdate 不会持续运行
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    public void ChangeHP(int amount)
    {
        if (amount < 0) {
            if (isInvincible) return;
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        currentHP = Mathf.Clamp(currentHP + amount, 0, maxHP);
        Debug.Log(currentHP);
    }
}

```

---

## Mac下.git文件夹不显示的问题
Mac 下 .git 文件夹不显示主要是由于隐藏文件/文件夹没有显示，就和 win 的隐藏文件一样。
在命令行中运行以下命令即可实现显示 `隐藏文件/夹`:
```
defaults write com.apple.finder.AppleShowAllFiles TRUE
killall Finder
```
如果重新把 `隐藏文件/夹` 隐藏起来，则只需把上面第一条命令中的 `TRUE` 改为 `FALSE`，然后重新运行两条命令即可。