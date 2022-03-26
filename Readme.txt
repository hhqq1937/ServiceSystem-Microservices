基础服务采用DDD领域驱动设计
代码结构描述：
|--Apis                       Api接口层
|   |--model                  视图模型
|   |--assembler              装配器，实现模型转换 apiModel<=> domainModel
|   |--controller             控制器，对外接口
|
|--application                应用层
|   |--service                应用服务，非核心服务
|   |--task                   任务定义，协调领域模型
|   |--***                    其他
|
|--domain                     领域层
|    |--common                公共代码抽取，限于领域层有效
|    |--events                领域事件
|    |--model                 领域模型
|    |    |--dict             领域划分的模块，子域
|    |         |-- value      值对象
|    |         |-- Entity     实体对象
|    |         |--Agg         领域聚合，需要聚合根
|    |--service               领域服务类，一些不能归属某个具体领域的领域模型的行为
|    |--factory               工厂类，负责负责领域对象的创建，封装细节
|    |--Repository            仓储类，不负责实现
|
|--infrastructure             基础设施层
|      |--persistent          持久化机制
|      |     |--Repostory     仓储类，负责持久化的实现，与ORM结合
|      |     |--Entity        持久化对象
|      |
|      |--general             通用技术支持
|      |     |--config        配置类
|      |     |--tool          工具类
|      |     |--common        基础公共模块
