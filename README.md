# Adb Apk Installer Tool

## Instalador de APK via ADB


## O que a tool faz?
* Basicamente ela executa um comando de instalação do apk desejado
* Facilita em vez de ficar transferindo o APK ou executando o comando e trocando o nome do arquivo a instalar toda hora
* Facilita tambem não precisar ficar desistalando o APK antes de instalar uma versão nova

```
comando cmd = adb install nomedoapk.apk
```

## Already Build Releases
[ReleaseBuild](https://raw.githubusercontent.com/igordias2/AdbApkInstallerTool/master/ReleaseBuild.zip)

Só extrair e usar o ReleaseBuild.zip


### Instruções de uso (Release Build):
```
-Vá nas opções de desenvolvedor do seu celular e ative o ADB
-Conecte há um cabo USB e permita usar o ADB pelo computador
-Instale o APK desejado
```



### Instruções de uso (Projeto): 
#### * (Caso queira usar o projeto e fazer qualquer modificação)
```
-Referencie as duas DLLs que estão na pasta DLL
-Adicione o ADB na pasta "adb" criada na root do projeto.
```

### Downloads: 
* [ADB](https://dl.google.com/android/repository/platform-tools_r28.0.0-windows.zip) *Já está encluso no projeto*
