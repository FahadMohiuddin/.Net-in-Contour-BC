using DependencyInjection;

IDependency MD = new MyDependency2();

var Consumer = new Consumer(MD);
Consumer.ConsumerThings();