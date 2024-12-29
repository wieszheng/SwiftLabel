# SwiftLabel 标签打印程序

## 功能简介

SwiftLabel是一个基于BarTender SDK开发的标签打印程序，主要用于条码标签的打印和验证。程序支持以下功能：

1. 标签模板加载与预览
2. 数据验证打印
3. 配置保存与加载
4. 自动打印模式

## 使用说明

### 基本操作

1. **模板选择**
   - 点击"打开文件"按钮选择.btw格式的标签模板
   - 程序会自动加载并显示预览图

2. **数据输入**
   - 在输入框中输入需要打印的数据
   - 按Enter键可触发自动打印（需开启自动打印）

### 数据验证功能

启用数据验证后，程序会根据设置的规则验证输入数据：

1. **验证规则设置**
   - 起始位置：从第几位开始截取
   - 连续长度：截取多少位
   - 验证内容：需要匹配的内容
   - 总长度：数据总长度验证

2. **验证逻辑**
   - 检查数据总长度是否符合设置
   - 验证指定位置的内容是否匹配
   - 所有验证通过后才会打印

### 配置管理

1. **保存配置**
   - 输入管理密码（默认：2024）
   - 点击"保存配置"按钮
   - 配置将保存在程序目录下的config.ini文件中

2. **配置项目**
   - 提示信息
   - 数据名称
   - 验证规则设置
   - 验证功能开关状态

### 配置文件说明

配置文件(config.ini)包含以下内容：
```
    ini
    [Settings]
    Hint=提示信息
    DataName=数据名称
    StartIndex=起始位置
    ContinuousLength=连续长度
    TotalLength=总长度
    VerifyText=验证内容
    VerifyEnabled=True/False

```

## 编译说明

### 开发环境要求

1. **开发工具**
   - Visual Studio 2019或更高版本
   - .NET Framework 4.7.2或更高版本

2. **依赖项**
   - BarTender SDK
     - 最低版本要求：2021
     - 需要安装BarTender开发包
   - System.Windows.Forms
   - System.Drawing

### 项目结构

```
SwiftLabel/
├── SwiftLabel.sln           # 解决方案文件
├── PringtForm.cs           # 主窗体代码
├── IniFile.cs             # INI配置文件处理类
├── README.md              # 说明文档
└── test.btw              # 测试用标签模板
```

### 编译步骤

1. **环境准备**
   - 安装Visual Studio
   - 安装BarTender SDK
   - 确保已安装.NET Framework开发包

2. **引用设置**
   - 添加BarTender SDK引用
     - Seagull.BarTender.Print
   - 确保System.Windows.Forms引用正确

3. **编译配置**
   - 平台目标：x86/x64（根据BarTender安装版本选择）
   - .NET Framework版本：4.7.2或更高
   - 输出类型：Windows应用程序

4. **发布准备**
   - 确保test.btw模板文件复制到输出目录
   - 检查所有必要的DLL依赖
   - 建议使用Release配置进行最终编译

### 调试说明

1. **常见调试问题**
   - BarTender服务未启动
   - SDK引用路径错误
   - 权限不足

2. **调试建议**
   - 使用Visual Studio调试工具
   - 检查BarTender服务状态
   - 验证配置文件读写权限

### 发布注意事项

1. **必要文件**
   - 主程序exe
   - 配置文件模板
   - 依赖的DLL文件
   - 默认标签模板

2. **运行环境要求**
   - Windows 7或更高版本
   - .NET Framework 4.7.2运行时
   - BarTender运行环境


## 技术支持

如有问题请联系技术支持人员。