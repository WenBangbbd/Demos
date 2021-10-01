public class NormalSingleton {
    private  NormalSingleton(){}
    private  static  NormalSingleton _instance;

    public static NormalSingleton GetInstatnce()
    {
        if(_instance!=null)
        {
            synchronized (NormalSingleton.class){
                if(_instance!=null){
                    return _instance;
                }
                _instance=new NormalSingleton();
            }
        }
        return _instance;
    }
}
