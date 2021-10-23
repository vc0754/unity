## Unity 学习笔记

## 2D

### * [官方2D路线图](https://unity.com/cn/roadmap/unity-platform/2d)

### * [平台游戏 Microgame](https://learn.unity.com/project/ping-tai-you-xi-microgame?uv=2019.3)

[当前阅读进度](https://learn.unity.com/tutorial/2d-ping-tai-you-xi-xiu-gai-you-se-shi-jie?uv=2019.3&projectId=5facf6bcedbc2a043f509bd7#)

### * [创作者套件：RPG](https://learn.unity.com/project/chuang-zuo-zhe-tao-jian-rpg?uv=2020.3)

[当前阅读进度](https://learn.unity.com/tutorial/tian-chong-ni-de-shi-jie?uv=2020.3&projectId=5facfb7dedbc2a001f53383c#6073f4b4edbc2a001f576ac6)

### * [Ruby's Adventure：2D 初学者](https://learn.unity.com/project/ruby-s-adventure-2d-chu-xue-zhe)

[当前阅读进度 - 装饰世界](https://learn.unity.com/tutorial/zhuang-shi-shi-jie?uv=2020.3&projectId=5facf921edbc2a2003a58d3a)

## Cinemachine

[Cinemachine](https://learn.unity.com/tutorial/cinemachine#)

[摄像机 - Cinemachine](https://learn.unity.com/tutorial/she-xiang-ji-cinemachine?projectId=5facf921edbc2a2003a58d3a#)

---

### 手册

[UnityWebRequest](https://docs.unity3d.com/cn/2020.3/Manual/UnityWebRequest.html)

[瓦片地图渲染器 (Tilemap Renderer)](https://docs.unity3d.com/cn/2020.3/Manual/class-TilemapRenderer.html)

---

### 哔哩哔哩

[【游戏开发】Unity 2D 角色控制逻辑教程（移动，翻滚，瞬移）](https://www.bilibili.com/video/av94823619/)

[M_Studio - 3DRPG核心教程每周五晚6:30更新！各平台请看公告](https://space.bilibili.com/370283072/)

[谜样神君 - RPG Marker](https://space.bilibili.com/2394867)

[哔哩哔哩 搜索 tile地图](https://search.bilibili.com/all?keyword=tile%20地图)

---

## 最经典的十款 FC 红白机 RPG 游戏
[百度贴吧](http://tieba.baidu.com/p/6841888066)

---

## Mac下.git文件夹不显示的问题
Mac 下 .git 文件夹不显示主要是由于隐藏文件/文件夹没有显示，就和 win 的隐藏文件一样。
在命令行中运行以下命令即可实现显示 `隐藏文件/夹`:
```
defaults write com.apple.finder.AppleShowAllFiles TRUE
killall Finder
```
如果重新把 `隐藏文件/夹` 隐藏起来，则只需把上面第一条命令中的 `TRUE` 改为 `FALSE`，然后重新运行两条命令即可。