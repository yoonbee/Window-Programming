**is 키워드** - 특정 객체가 어떤 클래스인지를 확인

다형성 시, 클래스 자료형 변환 방법
is 키워드로 클래스 파악 후, ()을 이용한 일반적 Casting

```c#
static void Main(string[] args){
	List<Animal> Animals = new List<Animals>(){ /* 생략 */ }

	foreach(var item in Animals){
		item.Eant();
		item.Sleep();
	
		if(item is Dog){((Dog)item).Bark();}
		if(item is Cat){((Cat)item).Meow();}
	}
}
```

---

**as 키워드** 

다형성 시, 클래스 자료형 변환 방법
as 키워드를 사용하여 변환 타입 지정

```c#
foreach(var item in Animals){
	item.Eant();
	item.Sleep();
	
	var dog = item as Dog;
	if(dog!=null){dog.Bark();}
	
	var cat = item as Cat;
	if(cat!=null){cat.Meow();}
}
```

---

**base 키워드** - 특수한 이유(hiding 등)으로 인해 부모클래스의 메서드에 접근할 수 없을 때 사용

부모클래스 생성자 호출을 명시적으로 지정하고 싶을 때 사용

```c#
class Program{
	class Parent{
		public Parent() {Console.WriteLine("부모 생성자1");}
		public Parent(int param) {Console.WriteLine("부모 생성자2");}
	}
	
	class Child:Parent{
		public Child():base(10){
			Console.WriteLine("자식 생성자");
		}
	}
	
	static void Main(String[] args){
		Child childA = new Child();
	}
}
```

출력 결과: 	  부모 생성자2	
						자식 생성자

---



