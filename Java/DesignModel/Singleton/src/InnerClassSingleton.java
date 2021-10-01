public class InnerClassSingleton {
    private InnerClassSingleton(){}

    /**
    *@Description: 用到了一个知识点，在初始化静态变量时，jvm自动实现同步
    *@Param: 
    *@return: 
    */
    private static class InnerClass{
        private static InnerClassSingleton _instance=new InnerClassSingleton();
    }
    public static  InnerClassSingleton GetInsteace()
    {
        return InnerClass._instance;
    }
}
