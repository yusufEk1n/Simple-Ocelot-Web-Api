## Hızlı Başlangıç?

Not: root dizinde <b>quickStarted.sh</b> dosyasını konsol'dan çalıştırın.

## Mikroservis Nedir?

En ham haliyle bir iş yapmak için için görevlendirilmiş birbirinden **bağımsız** çalışan yapılardır.


## API Gateway Nedir?

Api Gateway client tarafından gelen requestleri ilgili microservice’lere **route** etmektedir. Günümüzde bu bu görevi yapan birçok kütüphane mevcuttur. Bu uygulamada **Ocelot** kütüphanesi kullanıldı.

Teorik kısım bitiğine göre artık yaptığımız uygulamayı analiz edebiliriz.

**Adım 1** 

Aşağıdaki komutları kullanarak, mevcut dizininizde üç tane .net core projesi oluşturun.

```sh
dotnet new webapi --name productAPI
```
```sh
dotnet new webapi --name customerAPI
```
```sh
dotnet new webapi --name gatewayAPI
```

**Adım 2** 

productAPI projemizin içinde controller’a örnek bir kaç data ekleyelim.

![productController](/images/productController.jpg)

Daha sonra uygulamamızın **5002** ve **5003** portlarını kullanması için **launchSettings.json** içererisinde ufak bir konfigürasyon yapalım.

![productConf](/images/productConf.jpg)


Aynı şekilde customerAPI projemizin içinde controller’a örnek bir kaç data ekleyelim.

![customerController](/images/customerController.jpg)

Daha sonra uygulamamızın **5000** ve **5001** portlarını kullanması için **launchSettings.json** içererisinde ufak bir konfigürasyon yapalım.

![productConf](/images/customerConf.jpg)


**Adım 3** 

gatewayAPI projemizde ocelot paketini kuralım.

```sh
dotnet add package Ocelot
```

gatewayAPI projemizin içine ocelot.json dosyası oluşturarak servislerimizi tanıtalım.

![ocelotConf](/images/ocelotConf.jpg)

**Adım 4** 

Main dosyasında ocelot'un ayağa kalkmasını sağlayalım ve config'leri set edelim.

![main](/images/main.jpg)


### Sonuç

```sh
dotnet run 
```

komutu ile her uygulamayı ayrı ayrı ayağa kaldıralım.

Postman ile ApiGateway üzerinden servislere istekler gönderelim.

**ProductAPI** için;

![reqProductAPI](/images/reqProductAPI.jpg)


**CustomerAPI** için;

![reqCustomerAPI](/images/reqCustomerAPI.jpg)