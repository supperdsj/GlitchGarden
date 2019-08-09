* 通过 Main Camera 的 Background 设置黑边背景色
* 通过设置 Canvas 尺寸和缩放比例，同时再设置 Camera 的位置和 size（垂直/2）可以似坐标系单位易于计算，结合 Canvas/Camera 的位置偏移更可似原点为所需位置（本项目中 1 unit = 160像素，Canvas 为 1920*1080 scale 0.00625，Camera size 3.375，Canvas 和 Camera 计算后偏移 x5y3 对齐位置原点）
* Animation transition 内可设置动画切换前后动画播放量
* 图片的 Import Settings 内可使用 Pixels pre unit 改变图片显示大小
* Animation 可控制子对象动画
* Animation 内可通过 Curves 视图调整贝塞尔曲线和动画关键帧
