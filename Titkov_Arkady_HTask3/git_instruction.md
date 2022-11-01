
![](git+github.jpg)
# [Git? Git How To](https://github.com/Arkardy/git_instructions/blob/0a7213b9174760cc03b10c9c3143423894dfa3ca/git_instruction.md)  🥵 

**Содержание:**  

[Установка-Git](#1-установка-git)  
[Настройка Git](#2-настройка-git)  
[Создание репозитория](#3-cоздание-репозитория)  
[Добавить новые файлы в репозиторий](#4-добавить-новые-файлы-в-репозиторий)  
[Как проверить состояние репозитория](#5-как-проверить-состояние-репозитория)  
[Добавление изменений](#6-добавление-изменений)  
[Расширенное исспользование git add](#7-расширенное-исспользование-git-add)  
[История коммитов](#8-история)  
[Алиасы](#9-алиасы)  
[Получение предыдущих версий](#10-получение-предыдущих-версий)  
[Добавление ветки](#11-добавление-ветки)  
[Навигация по веткам](#12-навигация-по-веткам)  
[Слияние веток](#13-слияние-веток)  
[Разрешение конфликта](#14-разрешение-конфликта)  
[Работа с удалёнными репозиториями](#15-работа-с-удалёнными-репозиториями) 

**Git**  — мощная и сложная распределенная система контроля версий. Понимание всех возможностей git открывает для разработчика новые горизонты в управлении исходным кодом. Самый верный способ обучиться владению Git — испытать его своими руками.

## 1. Установка Git

Основой интерфейс для работы с **Git**-ом является консоль/терминал.  
  Установка **Git**:  
  - **Windows**  
    Переходим по этой [***ссылке***](https://git-scm.com/download/win), выбираем под вашу ОС (32 или 64 битную), скачиваем и устанавливаем.  
  - **MacOS**  
    ![MaxOs install](/MacOS_install.png)  
  - **Linux (Ubuntu, ArchLinx)**  
    **Debian или Ubuntu**  
    `sudo apt install git`  
    **ArchLinux**    
    `sudo pacman -S git`
	
## 2. Настройка Git

Вы установили себе **Git** и можете им пользоваться. Давайте теперь его настроим, чтобы когда вы создавали *commit*, указывался автор, кто его создал. Выполните следующие команды, чтобы **git** узнал ваше имя и электронную почту. Если **git** уже установлен, можете переходить к разделу окончания строк.

**Выполнить:**  
`git config --global user.name "Your Name"`  
и  
`git config --global user.email "your_email@whatever.com"`

**Параметры установки окончания строк**

- **Для пользователей** ***Unix/Mac***

 **Выполнить:**  
 `git config --global core.autocrlf input`  
 и  
 `git config --global core.safecrlf warn`
	
- **Для пользователей** ***Windows***

 **Выполнить:**
 
 `git config --global core.autocrlf input`       
 и  
 `git config --global core.safecrlf warn`

## 3. Создание репозитория
 
Чтобы создать **git** репозиторий из каталога, выполните команду *git init* в этом каталоге.

**Выполните:**

`git init`	
	
## 4. Добавить новые файлы в репозиторий

Теперь давайте добавим в репозиторий страницу «Hello, World» - hello.html.

**Выполните:**  

 `git add hello.html`  
 и  
 `git commit -m "First Commit"`
	
где "First commit" - Коммит - Название(Комментарий к) точки сохранения).

## 5. Как проверить состояние репозитория

Используйте команду *git status*, чтобы проверить текущее состояние репозитория.

**Выполните:**

`git status`	
	
Команда проверки состояния сообщит, что коммитить нечего. Это означает, что в репозитории хранится текущее состояние рабочего каталога, и нет никаких изменений, ожидающих записи.

>      Команда "git status", необходима, чтобы продолжать отслеживать состояние репозитория и рабочего каталога.

## 6. Добавление изменений

Если вы изменили файлы или добавили новые файлы, то набрав команду *git status* вы можете увидить следующий результат:  

      git status  
      On branch master  
      Changes not staged for commit:  
      (use "git add <file>..." to update what will be committed)  
      (use "git checkout -- <file>..." to discard changes in working directory)  
      
      modified:   hello.html  
      
      no changes added to commit (use "git add" and/or "git commit -a")"

Первое, что нужно заметить, это то, что **git** знает, что файл *hello.html* был изменен, но при этом эти изменения еще не зафиксированы в репозитории.

Также обратите внимание на то, что сообщение о состоянии дает вам подсказку о том, что нужно делать дальше. Если вы хотите добавить эти изменения в репозиторий, используйте команду *"git add"*. В противном случае используйте команду *"git сheckout"* для отмены изменений.

**Добавим изменения**

Дадим команду **git** проиндексировать изменения.

***Выполнить:***

`git add hello.html`

Изменения файла *hello.html* были проиндексированы. Это означает, что **git** теперь знает об изменении, но изменение пока не перманентно (читай, навсегда) записано в репозиторий. Следующий коммит будет включать в себя проиндексированные изменения.

***Если вы решили, что не хотите коммитить изменения, команда состояния напомнит вам о том, что с помощью команды **"git reset"** можно снять индексацию этих изменений.***

Отдельный шаг индексации в **git** позволяет вам продолжать вносить изменения в рабочий каталог, а затем, в момент, когда вы захотите взаимодействовать с версионным контролем, **git** позволит записать изменения в малых коммитах, которые фиксируют то, что вы сделали.

Предположим, что вы отредактировали три файла *(a.html, b.html, и c.html)*. Теперь вы хотите закоммитить все изменения, при этом чтобы изменения в *"a.html"* и *"b.html"* были одним коммитом, в то время как изменения в *"c.html"* логически не связаны с первыми двумя файлами и должны идти отдельным коммитом.

В теории, вы можете сделать следующее:

`git add a.html`  
Затем  
`git add b.html`  
Затем  
`git commit -m "Changes for a and b"`  
Затем   
`git add c.html` 

И наконец  

`git commit -m "Unrelated change to c"`
	
Разделяя индексацию и коммит, вы имеете возможность с легкостью настроить, что идет в какой коммит.

## 7. Расширенное исспользование git add

Давайте обозначим категории файлов, которые вообще можно добавлять. Будем использовать те же обозначения, что и в выводе команды *git status -s*:

**M - (modified)** отслеживаемые, изменились с прошлого коммита, еще не добавлены  
**D - (deleted)** отслеживаемые, удалены после прошлого коммита, еще не добавлены  
**? - (untracked)** неотслеживаемые, не запрещены к добавлению  
**! - (ignored)** неотслеживаемые, запрещены к добавлению (например, в .gitignore)

**Параметры и аргументы**

Первое различие  — в том, что . — это путь (аргумент), а всё остальное — параметры. Те и другие не исключают друг друга и возможны их сочетания.
Использование абсолютных ":/" и относительных "." путей с командой **add**

Путь . обозначает текущую директорию, т.е. ту, в которой была запущена команда.
> Начиная с Git версии 2.0, поведение команды **add** приведено в соответствие с поведением **commit** и других комманд. Теперь . обозначает не всю рабочую область *(working tree)*, а текущий путь в этой области.

> Таким образом, если вы выполняете команду **add** не в корневой директории проекта (той, где лежит .git/), то будет обработано содержимое только текущей директории.

Чтобы явным образом дать указание Git работать со всей рабочей областью, используйте ":/":
работает одинаково из любой директории, добавляет всю рабочую область  
`git add :/`  
путь относительно корневой директории  
`git add :/path/to/files/`  
работает только в текущей директории  
`cd test`
`git add .`  
эквивалентно этому:  
`git add :/test`  
путь относительно текущей директории  
`cd test`  
`git add ./path`  
эквивалентно этому:  
`git add :/test/path`

Если не указан никакой путь к добавляемым файлам, то большинство команд работает во всей рабочей области, а **"git add"** и **"git add --no-all"** **просто не работают.**

Сводная таблица  

|   | Changed | Untacked | Removed | Ignored | 
| :----: |:----:|:----:|:----:|:----:|
|Команды|Изменненые|Новые |Удаленные |Игнорируемые| 
|git add .(v 2.0+)|✅|✅|✅|✖️|
|git add -u|✅|✖️|✅|✖️|
|git add --all|✅|✅|✅|✖️|
|git add -no-all|✅|✅|✖️|✖️|
|git add -f .|✅|✅|✅|✅|
|git add *|⚠️|⚠️|✖️|⛔|   

**О функционале команд подробнее**
`git add .`
`git add '*'`

Git версии 2.0+ просматривает текущую папку и добавляет файлы M, D, ?.
Git версии 1.х просматривает всю рабочую область и добавляет файлы M, D.

Если `'*'` дается в кавычках, то обрабатывать его будет Git и это эквивалентно `git add ..` Исключение: из-под cmd.exe `git add '*'` не сработает, используйте `git add` . или `git add '*'`

`git add --no-all :/`  
`git add --ignore-removal :/`

Эта команда в Git v. 2.0+ работает как `git add .`  в Git v. 1.x, то есть добавляет измененные и новые файлы M, ? во всей рабочей области. **Для этой команды обязательно указывать путь.**

`git add --no-all .` #добавляет измененные и новые файлы в *текущей директории*  
`git add --no-all path1/ path2/` # добавляет измененные и новые файлы в путях относительно текущей директории

`git add -u`
`git add -update`

Git обновляет (update) статус уже отслеживаемых файлов т.е. M, D.

`git add -A`  
`git add --all`  
`git add --no-ignore-removal`  

Эти варианты эквивалентны и добавляют M, D, ?.

Без точки — из всей рабочей области:

>     git add -A = git add -A :/ = git add :/ + git add -u  

С точкой — только текущий путь:

>     git add -A . = git add . + git add -u .  

 `git add *` - Этот синтаксис лучше не использовать, и вот почему:

При этой команде shell (или bash или другая командная оболочка) просматривает рабочую область и отдает Git список файлов на добавление. Система сработает таким образом, что будут найдены абсолютно все не-скрытые файлы, находящиеся в заданном корне. Вы можете посмотреть на этот список, выполнив `echo *`. ( Исключение: из-под cmd.exe `git add *` работает так же как `git add '*'` на shell/bash.)

Произойдет следующее (здесь мы видим сразу несколько причин не использовать add *):

 Добавятся не изменившиеся с прошлого коммита файлы. Git спокойно и молча "прожует" этот запрос, не влияющий на индекс.
 Будут добавлены в индекс файлы в не-скрытых папках M,?.
 Не будут добавлены файлы в скрытых папках. .M, .?
Не будут добавлены удаленные файлы D.
Если будут захвачены игнорируемые файлы !, то будет попытка их добавить. Git отменит всю операцию и покажет сообщение об ошибке.

**Зачем столько способов**

Разнообразие параметров (-u, -A, --no-all) нужно для того, чтобы можно было добавлять разные группы файлов. Конкретно --no-all . было добавлено для того, чтобы реализовывать старое поведение add . в версиях 1.х.

Похоже, что несмотря на это, Git не позволяет добавлять конкретные группы файлов одной командой (см. сводную таблицу в начале).

Тонкости в использовании . и :/ нужны для того, чтобы каждую команду можно было выполнять как на всю рабочую область, так и на конкретную подпапку.


## 8. История
**Git** позволяет просматривать историю проекта.

Получение списка произведенных изменений — функция команды **"git log"**.
Выполните:

`git log`

Вы увидите…  
**Результат:**

      $ git log
      commit fa3c1411aa09441695a9e645d4371e8d749da1dc
      Author: Alexander Shvets <alex@githowto.com>
      Date:   Wed Mar 9 10:27:54 2011 -0500

      Added HTML header

      commit 8c3228730ed03116815a5cc682e8105e7d981928
      Author: Alexander Shvets <alex@githowto.com>
      Date:   Wed Mar 9 10:27:54 2011 -0500

      Added standard HTML page tags

      commit 43628f779cb333dd30d78186499f93638107f70b
      Author: Alexander Shvets <alex@githowto.com>
      Date:   Wed Mar 9 10:27:54 2011 -0500

            Added h1 tag

      commit 911e8c91caeab8d30ad16d56746cbd6eef72dc4c
      Author: Alexander Shvets <alex@githowto.com>
      Date:   Wed Mar 9 10:27:54 2011 -0500

         First Commit

Вот список всех четырех коммитов в репозиторий, которые мы успели совершить.
### Однострочная история

Вы полностью контролируете то, что отображает ***log***,  например, нравится однострочный формат:
Выполните:

`git log --pretty=oneline`

Вы увидите…
**Результат:**

      $ git log --pretty=oneline
      fa3c1411aa09441695a9e645d4371e8d749da1dc  Added HTML header
      8c3228730ed03116815a5cc682e8105e7d981928  Added standard HTML page tags
      43628f779cb333dd30d78186499f93638107f70b  Added h1 tag
      911e8c91caeab8d30ad16d56746cbd6eef72dc4c First Commit

**Контроль отображения записей**

Есть много вариантов выбора, какие элементы отображаются в логе. Поиграйте со следующими параметрами:

`git log --pretty=oneline --max-count=2`  
`git log --pretty=oneline --since='5 minutes ago`  
`git log --pretty=oneline --until='5 minutes ago`  
`git log --pretty=oneline --author=<your name>`  
`git log --pretty=oneline --all`  

В unix-системах доступна справочная страница `man git log`.

Для просмотра изменений, сделанных за последнюю неделю, от автора "alex" `--author=alex`

`git log --all --pretty=format:"%h %cd %s (%an)" --since='7 days ago'`

Еще удобный вывод 
### **Выполните:**

`git log --pretty=format:"%h %ad | %s%d [%an]" --graph --date=short`

Результат:

      $ git log --pretty=format:"%h %ad | %s%d [%an]" --graph --date=short
      * fa3c141 2011-03-09 |  Added HTML header (HEAD, master) [Alexander Shvets]
      * 8c32287 2011-03-09 |  Added standard HTML page tags [Alexander Shvets]
      * 43628f7 2011-03-09 |  Added h1 tag [Alexander Shvets]
      * 911e8c9 2011-03-09 | First Commit [Alexander Shvets]

Давайте рассмотрим его в деталях:

    --pretty="..." — определяет формат вывода.
    %h — укороченный хэш коммита
    %d — дополнения коммита («головы» веток или теги)
    %ad — дата коммита
    %s — комментарий
    %an — имя автора
    --graph — отображает дерево коммитов в виде ASCII-графика
    --date=short — сохраняет формат даты коротким и симпатичным

Таким образом, каждый раз, когда вы захотите посмотреть лог, вам придется много печатать. К счастью, мы узнаем о **git** ***алиасах*** далее.

## 9. Алиасы
Как настраивать алиасы и шорткаты для команд **git**

** Общие алиасы**

Для пользователей **Windows**  
**Выполнить:**

`git config --global alias.co checkout`  
`git config --global alias.ci commit`  
`git config --global alias.st status`  
`git config --global alias.br branch`   
`git config --global alias.hist "log --pretty=format:'%h %ad | %s%d [%an]' --graph --date=short`  
`git config --global alias.type 'cat-file -t`  
`git config --global alias.dump 'cat-file -p`    

Также, для пользователей **Unix/Mac**:

*git status*, *git add*, *git commit*, *git checkout* — общие команды, для которых полезно иметь сокращения.

Добавьте следующее в файл *.gitconfig* в вашем *$HOME* каталоге.
Файл: *.gitconfig*

      [alias]
      co = checkout
      ci = commit
      st = status
      br = branch
      hist = log --pretty=format:\"%h %ad | %s%d [%an]\" --graph --date=short
      type = cat-file -t
      dump = cat-file -p

## 10. Получение предыдущих версий
Как возвращать рабочий каталог к любому предыдущему состоянию.

Возвращаться назад в историю очень просто. Команда ***checkout*** скопирует любой снимок из репозитория в рабочий каталог.

Получите хэши предыдущих версий

      * fa3c141 2011-03-09 | Added HTML header (HEAD, master) [Alexander Shvets]
      * 8c32287 2011-03-09 | Added standard HTML page tags [Alexander Shvets]
      * 43628f7 2011-03-09 | Added h1 tag [Alexander Shvets]
      * 911e8c9 2011-03-09 | First Commit [Alexander Shvets]

Изучите данные лога и найдите хэш для первого коммита. Он должен быть в последней строке данных. Используйте этот хэш-код (достаточно первых 7 знаков) в команде ниже. Затем проверьте содержимое файла *hello.html*.  
**Выполните:**

`git checkout <hash>`  
`cat hello.html`

Примечание: Многие команды зависят от хэшевых значений в репозитории. Поскольку ваши хеш-значения будут отличаться от представленных в примере, когда вы видите что-то вроде `<hash> `или `<treehash> `в команде, подставьте необходимое значение хэш для вашего репозитория.

**Результат:**

`git checkout 911e8c9`  

      Note: checking out '911e8c9'.

      You are in 'detached HEAD' state. You can look around, make experimental
      changes and commit them, and you can discard any commits you make in this
      state without impacting any branches by performing another checkout.

      If you want to create a new branch to retain commits you create, you may
      do so (now or later) by using -b with the checkout command again. Example:


Выходные данные команды **checkout** очень хорошо объясняют ситуацию. Старые версии **git** будут ругаться, что не расположены в локальной ветке. В любом случае, сейчас об этом не беспокойтесь.

Обратите внимание на то, что содержимое файла *hello.html* является значением по умолчанию.

Вернитесь к последней версии в ветке *master*  
**Выполните:**  
`git checkout master`  

`cat hello.html`

Результат:

      $ git checkout master
      Previous HEAD position was 911e8c9... First Commit
      Switched to branch 'master'
      $ cat hello.html
      <html>
            <head>
            </head>
                  <body>
                        <h1>Hello, World!</h1>
                  </body>
      </html>

«master» — имя ветки по умолчанию. Переключая имена веток, вы попадаете на последнюю версию выбранной ветки.



## 11. Добавление ветки 
**Цель:**  
Научиться создавать локальную ветку в репозитории  
При внесении изменений, лучше переместить эти изменения в отдельную ветку, чтобы изолировать их от изменений в ветке **master**.  
**Создайте ветку**  
Давайте назовем нашу новую ветку **«style»**.  
**Выполните:**  
`git checkout -b style`  
`git status`  
*Примечание:* **git checkout -b <имяветки>** является шорткатом для **git branch <имяветки>** за которым идет **git checkout <имяветки>**.  
Обратите внимание, что команда **git status** сообщает о том, что вы находитесь в ветке *«style»*.  
Добавьте файл стилей *style.css*  
**Выполните:** 
   
`touch lib/style.css`  
  
**Выполните:**  

`git add lib/style.css`  
`git commit -m "Added css stylesheet"`  
  
Измените основную страницу и выполните  
  
**Выполните:**  
  
`git add lib/hello.html`  
`git commit -m "Hello uses style.css"`  

## 12. Навигация по веткам  
**Цели** Научиться перемещаться между ветками репозитория

Теперь в вашем проекте есть две ветки:  

**Выполните:**

`git hist --all`

**Результат:**

      $ git hist --all
      * 07a2a46 2011-03-09 | Updated index.html (HEAD, style) [Alexander Shvets]
      * 649d26c 2011-03-09 | Hello uses style.css [Alexander Shvets]
      * 1f3cbd2 2011-03-09 | Added css stylesheet [Alexander Shvets]
      * 8029c07 2011-03-09 | Added index.html. (master) [Alexander Shvets]
      * 567948a 2011-03-09 | Moved hello.html to lib [Alexander Shvets]
      * 6a78635 2011-03-09 | Add an author/email comment [Alexander Shvets]
      * fa3c141 2011-03-09 | Added HTML header (v1) [Alexander Shvets]
      * 8c32287 2011-03-09 | Added standard HTML page tags (v1-beta) [Alexander Shvets]
      * 43628f7 2011-03-09 | Added h1 tag [Alexander Shvets]
      * 911e8c9 2011-03-09 | First Commit [Alexander Shvets]

Переключение на ветку **Master**

Просто используйте команду **git checkout** для переключения между ветками.  

**Выполните:**  

`git checkout master`  
`cat lib/hello.html`  

**Результат:**

      $ git checkout master
      Switched to branch 'master'
      $ cat lib/hello.html
      <!-- Author: Alexander Shvets (alex@githowto.com) -->
      <html>
        <head>
        </head>
          <body>
             <h1>Hello, World!</h1>
          </body>
      </html>

Сейчас мы находимся на ветке **Master**. Это заметно по тому, что файл *hello.html* не использует стили *style.css*.

Вернемся к ветке *«style»*.  

**Выполните:**

`git checkout style`  
`cat lib/hello.html`  

**Результат:**

      $ git checkout style
      Switched to branch 'style'
      $ cat lib/hello.html
      <!-- Author: Alexander Shvets (alex@githowto.com) -->
      <html>
        <head>
            <link type="text/css" rel="stylesheet" media="all" href="style.css" />
        </head>
        <body>
            <h1>Hello, World!</h1>
        </body>
      </html>

Содержимое *lib/hello.html* подтверждает, что мы вернулись в ветку *style*.

## 13. Слияние веток  
**Цель:**  
Научиться сливать две отличающиеся ветки для переноса изменений обратно в одну ветку.  
**Слияние веток**  
Слияние переносит изменения из двух веток в одну. Давайте вернемся к ветке *style* и сольем **master** с *style*.  
**Выполните:**  
`git checkout style`  
`git merge master`  
`git hist --all`  
**Результат:**  

    $ git checkout style  
        Switched to branch 'style'  
    $ git merge master  
        Merge made by recursive.  
        README |    1 +  
        1 files changed, 1 insertions(+), 0 deletions(-)  
        create mode 100644 README  
    $ git hist --all
        *   5813a3f 2011-03-09 | Merge branch 'master' into style (HEAD, style) [Alexander Shvets]
        |\  
        | * 6c0f848 2011-03-09 | Added README (master) [Alexander Shvets]
        * | 07a2a46 2011-03-09 | Updated index.html [Alexander Shvets]
        * | 649d26c 2011-03-09 | Hello uses style.css [Alexander Shvets]
        * | 1f3cbd2 2011-03-09 | Added css stylesheet [Alexander Shvets]
        |/  
        * 8029c07 2011-03-09 | Added index.html. [Alexander Shvets]
        * 567948a 2011-03-09 | Moved hello.html to lib [Alexander Shvets]
        * 6a78635 2011-03-09 | Add an author/email comment [Alexander Shvets]
        * fa3c141 2011-03-09 | Added HTML header (v1) [Alexander Shvets]
        * 8c32287 2011-03-09 | Added standard HTML page tags (v1-beta) [Alexander Shvets]
        * 43628f7 2011-03-09 | Added h1 tag [Alexander Shvets]
        * 911e8c9 2011-03-09 | First Commit [Alexander Shvets]

Путем периодического слияния ветки master с веткой *style* вы можете переносить из master любые изменения и поддерживать совместимость изменений *style* с изменениями в основной ветке.  
Однако, это делает графики коммитов действительно уродливыми. Позже мы рассмотрим возможность перебазирования, как альтернативы слиянию.  
  
## 14. Разрешение конфликта  
  
**Создание конфликта**

Но что если изменения в ветке **master **конфликтуют с изменениями в *style*?
Создание конфликтующих изменений в ветке **master**.

Вернитесь в **master** и создайте конфликт

Вернитесь в ветку **master** и внесите следующие изменения:

`git checkout master`

Файл: *lib/hello.html*  

      <!-- Author: Alexander Shvets (alex@githowto.com) -->
      <html>
          <head>
             <!-- no style -->
          </head>  
              <body> 
                  <h1>Hello, World! Life is great!</h1>  
              </body> 
      </html> 

**Выполните:**

`git add lib/hello.html`  
`git commit -m 'Life is great!'`  

*Внимание: используйте для этого коммита одинарные кавычки, дабы избежать проблем с символом !. В bash он считается служебным.*  
**Просмотр веток**  
  
**Выполните:**

`git hist --all`

**Результат:**

    $ git hist --all
    * 454ec68 2011-03-09 | Life is great! (HEAD, master) [Alexander Shvets]
    | * 5813a3f 2011-03-09 | Merge branch 'master' into style (style) [Alexander Shvets]
    | |\  
    | |/  
    |/| 
    * | 6c0f848 2011-03-09 | Added README [Alexander Shvets]
    | * 07a2a46 2011-03-09 | Updated index.html [Alexander Shvets]
    | * 649d26c 2011-03-09 | Hello uses style.css [Alexander Shvets]
    | * 1f3cbd2 2011-03-09 | Added css stylesheet [Alexander Shvets]
    |/  
    * 8029c07 2011-03-09 | Added index.html. [Alexander Shvets]
    * 567948a 2011-03-09 | Moved hello.html to lib [Alexander Shvets]
    * 6a78635 2011-03-09 | Add an author/email comment [Alexander Shvets]
    * fa3c141 2011-03-09 | Added HTML header (v1) [Alexander Shvets]
    * 8c32287 2011-03-09 | Added standard HTML page tags (v1-beta) [Alexander Shvets]
    * 43628f7 2011-03-09 | Added h1 tag [Alexander Shvets]
    * 911e8c9 2011-03-09 | First Commit [Alexander Shvets]

После коммита *«Added README»* ветка **master** была объединена с веткой *style*, но в настоящее время в **master** есть дополнительный коммит, который не был слит с *style*.

Последнее изменение в **master** конфликтует с некоторыми изменениями в *style*.  
  
На следующем шаге мы решим этот конфликт.  

Научиться разрешать конфликты во время слияния

Слияние master с веткой *style*

Теперь вернемся к ветке *style* и попытаемся объединить ее с новой веткой **master**.
**Выполните:**

`git checkout style`
`git merge master`

**Результат:**

    $ git checkout style
    Switched to branch 'style'
    $ git merge master
    Auto-merging lib/hello.html
    CONFLICT (content): Merge conflict in lib/hello.html
    Automatic merge failed; fix conflicts and then commit the result.

Если вы откроете *lib/hello.html,* вы увидите:
Файл: *lib/hello.html*

    <!-- Author: Alexander Shvets (alex@githowto.com) -->
    <html>
    <head>
    <<<<<<< HEAD
        <link type="text/css" rel="stylesheet" media="all" href="style.css" />
    =======
        <!-- no style -->
    >>>>>>> master
    </head>
    <body>
        <h1>Hello,World! Life is great!</h1>
    </body>
    </html>

Первый раздел - версия во главе текущей ветки *(style)*. Второй раздел - версия ветки **master**.

**Решение конфликта**

Вам необходимо вручную разрешить конфликт. Внесите изменения в *lib/hello.htm*l для достижения следующего результата.
Файл: *lib/hello.html*

    <!-- Author: Alexander Shvets (alex@githowto.com) -->
    <html>
    <head>
        <link type="text/css" rel="stylesheet" media="all" href="style.css" />
    </head>
    <body>
        <h1>Hello, World! Life is great!</h1>
    </body>
    </html>


Сделайте коммит решения конфликта
**Выполните:**

`git add lib/hello.html`  
`git commit -m "Merged master fixed conflict."`

**Результат:**

    $ git add lib/hello.html
    $ git commit -m "Merged master fixed conflict."
    Recorded resolution for 'lib/hello.html'.
    [style 645c4e6] Merged master fixed conflict.

## 15. Работа с удалёнными репозиториями  

**Работа с удалёнными репозиториями**

Для того, чтобы внести вклад в какой-либо **Git**-проект, вам необходимо уметь работать с удалёнными репозиториями. Удалённые репозитории представляют собой версии вашего проекта, сохранённые в интернете или ещё где-то в сети. У вас может быть несколько удалённых репозиториев, каждый из которых может быть доступен для чтения или для чтения-записи. Взаимодействие с другими пользователями предполагает управление удалёнными репозиториями, а также отправку и получение данных из них. Управление репозиториями включает в себя как умение добавлять новые, так и умение удалять устаревшие репозитории, а также умение управлять различными удалёнными ветками, объявлять их отслеживаемыми или нет и так далее. В данном разделе мы рассмотрим некоторые из этих навыков.

***Примечание***
	
*Удаленный репозиторий может находиться на вашем локальном компьютере.*  
  
Вполне возможно, что удалённый репозиторий будет находиться на том же компьютере, на котором работаете вы. Слово «удалённый» не означает, что репозиторий обязательно должен быть где-то в сети или Интернет, а значит только — где-то ещё. Работа с таким удалённым репозиторием подразумевает выполнение стандартных операций отправки и получения, как и с любым другим удалённым репозиторием.  
  
**Просмотр удалённых репозиториев**

Для того, чтобы просмотреть список настроенных удалённых репозиториев, вы можете запустить команду **git remote**. Она выведет названия доступных удалённых репозиториев. Если вы клонировали репозиторий, то увидите как минимум *origin* — имя по умолчанию, которое **Git** даёт серверу, с которого производилось клонирование:

`$ git clone https://github.com/schacon/ticgit`  

      Cloning into 'ticgit'...
      remote: Reusing existing pack: 1857, done.
      remote: Total 1857 (delta 0), reused 0 (delta 0)
      Receiving objects: 100% (1857/1857), 374.35 KiB | 268.00 KiB/s, done.
      Resolving deltas: 100% (772/772), done.
      Checking connectivity... done.
      $ cd ticgit
      $ git remote origin

Вы можете также указать ключ *-v*, чтобы просмотреть адреса для чтения и записи, привязанные к репозиторию:  

`$ git remote -v`  

      origin	https://github.com/schacon/ticgit (fetch)
      origin	https://github.com/schacon/ticgit (push)

Если у вас больше одного удалённого репозитория, команда выведет их все. Например, для репозитория с несколькими настроенными удалёнными репозиториями в случае совместной работы нескольких пользователей, вывод команды может выглядеть примерно так:

`$ cd grit`  
`$ git remote -v`  

      bakkdoor  https://github.com/bakkdoor/grit (fetch)
      bakkdoor  https://github.com/bakkdoor/grit (push)
      cho45     https://github.com/cho45/grit (fetch)
      cho45     https://github.com/cho45/grit (push)
      defunkt   https://github.com/defunkt/grit (fetch)
      defunkt   https://github.com/defunkt/grit (push)
      koke      git://github.com/koke/grit.git (fetch)
      koke      git://github.com/koke/grit.git (push)
      origin    git@github.com:mojombo/grit.git (fetch)
      origin    git@github.com:mojombo/grit.git (push)

Это означает, что мы можем легко получить изменения от любого из этих пользователей. Возможно, что некоторые из репозиториев доступны для записи и в них можно отправлять свои изменения, хотя вывод команды не даёт никакой информации о правах доступа.

Обратите внимание на разнообразие протоколов, используемых при указании адреса удалённого репозитория;

 Для того, чтобы добавить удалённый репозиторий и присвоить ему имя *(shortname)*, просто выполните команду ***git remote add <shortname> <url>:***

`$ git remote origin`  
`$ git remote add pb https://github.com/paulboone/ticgit`  
`$ git remote -v`  

      origin	https://github.com/schacon/ticgit (fetch)
      origin	https://github.com/schacon/ticgit (push)
      pb	https://github.com/paulboone/ticgit (fetch)
      pb	https://github.com/paulboone/ticgit (push)

Теперь вместо указания полного пути вы можете использовать **pb**. Например, если вы хотите получить изменения, которые есть у Пола, но нету у вас, вы можете выполнить команду **git fetch pb:**

`$ git fetch pb`

      remote: Counting objects: 43, done.
      remote: Compressing objects: 100% (36/36), done.
      remote: Total 43 (delta 10), reused 31 (delta 5)
      Unpacking objects: 100% (43/43), done.
      From https://github.com/paulboone/ticgit
      * [new branch]      master     -> pb/master
      * [new branch]      ticgit     -> pb/ticgit

Ветка **master** из репозитория Пола сейчас доступна вам под именем *pb/master*. Вы можете слить её с одной из ваших веток или переключить на неё локальную ветку, чтобы просмотреть содержимое ветки Пола. 
Получение изменений из удалённого репозитория — **Fetch** и **Pull**

Как вы только что узнали, для получения данных из удалённых проектов, следует выполнить:

`$ git fetch [remote-name]`

Данная команда связывается с указанным удалённым проектом и забирает все те данные проекта, которых у вас ещё нет. После того как вы выполнили команду, у вас должны появиться ссылки на все ветки из этого удалённого проекта, которые вы можете просмотреть или слить в любой момент.

Когда вы клонируете репозиторий, команда **clone** автоматически добавляет этот удалённый репозиторий под именем **«origin»**. Таким образом, **git fetch origin** извлекает все наработки, отправленные на этот сервер после того, как вы его клонировали (или получили изменения с помощью **fetch**). Важно отметить, что команда **git fetch** забирает данные в ваш локальный репозиторий, но не сливает их с какими-либо вашими наработками и не модифицирует то, над чем вы работаете в данный момент. Вам необходимо вручную слить эти данные с вашими, когда вы будете готовы.

Если ветка настроена на отслеживание удалённой ветки (см. следующий раздел и главу Ветвление в **Git** чтобы получить больше информации), то вы можете использовать команду **git pull** чтобы автоматически получить изменения из удалённой ветки и слить их со своей текущей. Этот способ может для вас оказаться более простым или более удобным. К тому же, по умолчанию команда **git clone** автоматически настраивает вашу локальную ветку master на отслеживание удалённой ветки master на сервере, с которого вы клонировали репозиторий. Название веток может быть другим и зависит от ветки по умолчанию на сервере. Выполнение **git pull**, как правило, извлекает (fetch) данные с сервера, с которого вы изначально клонировали, и автоматически пытается слить **(merge)** их с кодом, над которым вы в данный момент работаете.  

***Примечание*** *Начиная с версии 2.27, команда **git pull** выдаёт предупреждение, если настройка **pull.rebase** не установлена. **Git** будет выводить это предупреждение каждый раз пока настройка не будет установлена.*

Если хотите использовать поведение Git по умолчанию (простое смещение вперёд если возможно — иначе создание коммита слияния): *git config --global pull.rebase "false"*

Если хотите использовать перебазирование при получении изменений: *git config --global pull.rebase "true"*
Отправка изменений в удаленный репозиторий **(Push)**

Когда вы хотите поделиться своими наработками, вам необходимо отправить их в удалённый репозиторий. Команда для этого действия простая: *git push <remote-name> <branch-name>*. Чтобы отправить вашу ветку master на сервер origin (повторимся, что клонирование обычно настраивает оба этих имени автоматически), вы можете выполнить следующую команду для отправки ваших коммитов:

`$ git push origin master`

Эта команда срабатывает только в случае, если вы клонировали с сервера, на котором у вас есть права на запись, и если никто другой с тех пор не выполнял команду *push*. Если вы и кто-то ещё одновременно клонируете, затем он выполняет команду *push*, а после него выполнить команду *push* попытаетесь вы, то ваш *push* точно будет отклонён. Вам придётся сначала получить изменения и объединить их с вашими и только после этого вам будет позволено выполнить *push*. Обратитесь к главе Ветвление в **Git** для более подробного описания, как отправлять изменения на удалённый сервер.  

**Просмотр удаленного репозитория**

Если хотите получить побольше информации об одном из удалённых репозиториев, вы можете использовать команду **git remote show <remote>**. Выполнив эту команду с некоторым именем, например, *origin*, вы получите следующий результат:

`$ git remote show origin`  

      * remote origin
      Fetch URL: https://github.com/schacon/ticgit
      Push  URL: https://github.com/schacon/ticgit
      HEAD branch: master
      Remote branches:
      master                               tracked
      dev-branch                           tracked
      Local branch configured for 'git pull':
      master merges with remote master
      Local ref configured for 'git push':
      master pushes to master (up to date)

Она выдаёт **URL** удалённого репозитория, а также информацию об отслеживаемых ветках. Эта команда любезно сообщает вам, что если вы, находясь на ветке **master**, выполните **git pull**, ветка master с удалённого сервера будет автоматически влита в вашу сразу после получения всех необходимых данных. Она также выдаёт список всех полученных ею ссылок.

Это был пример для простой ситуации и вы наверняка встречались с чем-то подобным. Однако, если вы используете **Git** более интенсивно, вы можете увидеть гораздо большее количество информации от **git remote show**:

`$ git remote show origin`  

      * remote origin
      URL: https://github.com/my-org/complex-project
      Fetch URL: https://github.com/my-org/complex-project
      Push  URL: https://github.com/my-org/complex-project
      HEAD branch: master
      Remote branches:
      master                           tracked
      dev-branch                       tracked
      markdown-strip                   tracked
      issue-43                         new (next fetch will store in remotes/origin)
      issue-45                         new (next fetch will store in remotes/origin)
      refs/remotes/origin/issue-11     stale (use 'git remote prune' to remove)
      Local branches configured for 'git pull':
      dev-branch merges with remote dev-branch
      master     merges with remote master
      Local refs configured for 'git push':
      dev-branch                     pushes to dev-branch                     (up to date)
      markdown-strip                 pushes to markdown-strip                 (up to date)
      master                         pushes to master                         (up to date)

Данная команда показывает какая именно локальная ветка будет отправлена на удалённый сервер по умолчанию при выполнении **git push**. Она также показывает, каких веток с удалённого сервера у вас ещё нет, какие ветки всё ещё есть у вас, но уже удалены на сервере, и для нескольких веток показано, какие удалённые ветки будут в них влиты при выполнении **git pull**.
Удаление и переименование удалённых репозиториев

Для переименования удалённого репозитория можно выполнить git remote rename. Например, если вы хотите переименовать **pb** в **paul**, вы можете это сделать при помощи **git remote rename**:

`$ git remote rename pb paul`
`$ git remote`  

      origin
      paul

Стоит упомянуть, что это также изменит имена удалённых веток в вашем репозитории. То, к чему вы обращались как **pb/master**, теперь стало **paul/master**.

Если по какой-то причине вы хотите удалить удаленный репозиторий — вы сменили сервер или больше не используете определённое зеркало, или кто-то перестал вносить изменения — вы можете использовать **git remote rm**:

`$ git remote remove paul`
`$ git remote origin`

При удалении ссылки на удалённый репозиторий все отслеживаемые ветки и настройки, связанные с этим репозиторием, так же будут удалены.
