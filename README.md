# Unity 学习笔记

## 2D

[官方2D路线图](https://unity.com/cn/roadmap/unity-platform/2d)

## 教程

* [官方教程] [Ruby's Adventure：2D 初学者](https://learn.unity.com/project/ruby-s-adventure-2d-chu-xue-zhe)

  项目 ● 初学者 ● 14 小时 20 分钟 ● 知识点 29 ● 类型 RPG
  
  ★ 当前阅读进度
  [世界交互 - 阻止移动 - 12.添加瓦片地图碰撞](https://learn.unity.com/tutorial/shi-jie-jiao-hu-zu-zhi-yi-dong?uv=2020.3&projectId=5facf921edbc2a2003a58d3a#6073de22edbc2a0021c5b6fb)

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
  * [indienova 独立游戏](https://indienova.com/sp/gameDevResource)
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
    // Start is called before the first frame update
    void Start()
    {
        // 更改每秒渲染帧数
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 36;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + 5f * horizontal * Time.deltaTime;
        position.y = position.y + 5f * vertical * Time.deltaTime;
        transform.position = position;
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