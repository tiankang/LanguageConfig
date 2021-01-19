# LanguageConfig
配置解析是用的另外一个开源代码 https://github.com/RickJiangShu/ConfigManager
之所以引用这套代码 我个人觉得比较简洁上手也容易。

LanguageConfig只是为了让语言配置表更加方便灵活，这套思路实现基于UGUI，想要实现其他的ui也是非常容易的。只需要让LanguageText继承其他Text的基类
实现一下函数即可。
主要还是提高项目的开发效率

使用方法也很简单只需要几个步骤：
右键在Canvas下创建LanguageText即可。新文本的话需要填写一下LanguageID 沿用其他已有文本只需要填写对应id,在Text初始化的时候会自动去取语言表的ID。
界面存成prefab之后放在Resource/UIPrefab即可。
在Toos 工具里面点击生成excel 就会把UIprefab下面的文本以及id对应的写入excel表。
极大减少策划与程序的时间成本。当然也可以直接在excel里面修改再导出。
导出之后 再点击output 即可把excel导入到工程里面。

需要注意的就是两个id相同 文本不同的情况 后者会顶替前者的文字内容
