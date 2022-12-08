
# **Инструкция для работы с Git и удалёнными репозиториями**

## **Что такое Git?**
___
**Git** - это одна из реализаций распределённых систем контроля версий, имеющая как и локальные, так и удалённые репозитории.

*Является самой популярной реализацией систем контроля версий в мире.*

[Нажми сюда, чтобы скачать Git для Windows, MAC, Linux.](https://git-scm.com/downloads)

## **Предварительная проверка и настройка**
***
Прежде чем создавать репозиторий и инициализировать Git, проверим текущую установленную 
версию пограммы. Для этого в терминале введём команду:
*git --version*.

При первом использовании Git необходимо представиться.  Для этого нужно ввести в терминале 2 команды по очереди:

*git config --global user.name "ваше имя английскими буквами"*

*git config --global user.email "ваша почта@example.com*".

(имя и email указываются в кавычках)

Для проверки имени и почты используйте те же команды, но без имени и почты: *git config --global user.name* и *git config --global user.email*.

## **Подготовка репозитория**
___
Для создания репозитория необходимо выполнить команду *git init* (от англ. initialization - "инициализация") **в папке с репозиторием**. И у вас создаться репозиторий - появится скрытая папка .git.

![Пример git init](git_init.jpg)


## **Создание коммитов**
***
### **Git add**
Для добавления измений в коммит используется команда *git add*. Чтобы использовать команду *git add* напишите *git add <имя файла>*.

![Пример git add](git_add.jpg)

### **Просмотр состояния репозитория**
Для того, чтобы посмотреть состояние репозитория используется команда *git status*. Для этого необходимо в папке с репозиторием написать *git status*, и Вы увидите были ли измения в файлах, или нет.

### __Создание коммитов__
Для того, чтобы создать коммит (сохранение) необходимо выполнить команду *git commit*.

Выполняется она так:

*git commit -m "<сообщение к коммиту>*.

Все файлы для коммита должны быть *__ДОБАВЛЕНЫ__* и сообщение к коммиту писать _**ОБЯЗАТЕЛЬНО**_.

![Пример git commit](git_commit.jpg)

## **Перемещение между сохранениями**
***
Для того, чтобы перемещаться между коммитами, используется команда *git checkout*.

Используется она в папке с репозиторием следующим образом:

*git checkout <номер коммита>*.

Команда *git checkout master* - возвращает в текущий коммит, в котором работали изначально 


## **Журнал изменений**
***

Для того, чтобы посмотреть все сделанные изменения в репозитории, используется команда *git log*.

Для этого достаточно выполнить команду *git log* в папке с репозиторием.

![Пример git log](git_log.jpg)

Команда *git diff* – позволяет увидеть разницу между текущим файлом и закоммиченным файлом

![Пример git diff](git_diff.jpg)

## **Ветки в Git**
***
### __Создание ветки__

Для того, чтобы создать ветку, используется команда *git branch*.

Делается это следующим образом в папке с репозиторием: *git branch <название новой ветки>*.

### __Слияние веток__

Для добавления/слияния ветки в текущую ветку используется команда *git merge*
Делается это следующим образом:
*git merge <название ветки>*.


**Обязательно до этого нужно перейти в нужную ветку с помощью команды _git checkout <имя ветки>_, в которой будет происходить слияние.**

### __Удаление веток__

Для удаления ветки ввести команду: *"git branch -d <название ветки>"*.
Эта команду вводить после слияния веток.

Если с этой веткой не будет происходить слияние, то удаление необходимо выполнить следующей командой:
*"git branch -D <название ветки>"*.

*Буква "D" заглавная!*

![Пример удаления неиспользованной ветки](git_delete.jpg)

### __Отображение журнала с ветками__
В Git можно просмотреть журнал изменений с ветками.

Для этого нужно ввести команду: *git log --graph*.

Для просмотра изменений в ветках можно вводить команду:
*git diff <name_branch1>..<name_branch2>*
Например: git diff master..branch2

Существует интерактивный тренажёр, на котором можно отработать все команды с ветками и даже больше.
Для этого прейдите по [ссылке.](https://learngitbranching.js.org/?locale=ru_RU)

## **Дополнительные команды для Git**
* *ls* - показывает видимое содержимое папки (вложенные папки и файлы);
* *ls - a* - показывает всё содержимое папки, в том числе и скрытое;
* *cd ..* - переводит на 1 уровень выше в каталоге папок (перед двумя точками обязательно ставить пробел);
* *cd <имя папки>* - переводит в папку с соответствующим названием;
* *mkdir <имя папки>* - создает папку с нужным названием (предварительно необходимо перейти в папку, в которой нужно создать новую папку с помощью команды *cd*);
* *touch <имя файла.расширение>* - создает файл с нужным расширением
* *clear* - очищает журнал терминала Git
* *.gitignore* - создание этого файла позволяет скрыть те файлы, которые фиксировать Git не нужно. Для этого нужно внутрь него ввести имена файлов с расширением, которые нужно игнорировать. Далее этот файл нужно добавить и зафиксировать изменения с помощью команд *git add* и *git commit*.

## **Немного слов о GitHub**
---
Это сервис компании Майкрософт для организации работы удаленных 
репозиториев.

Является самым популярным сервисом Git.

В нем много полезных функций. Есть огромный архив различного кода. Можно принимать участие в различных проектах.

### **Как разместить свой репозиторий на GitHub**
___

1. Зарегистрироваться.
2. Через "+" добавить новый репозиторий. Оставить настройки по умолчанию. Нажать на "Create repository".

![Окно регистрации репозитория на GitHub](Repository_gitHub.jpg)

3. Создать локальный репозиторий на ПК. Для этого надо создать папку, внутри неё вызвать команду git init, совершить какие-то действия, создать файлы, чтобы появился хотя бы один коммит.
4. Скопировать ссылку на созданный удалённый репозиторий.
5. На компьютере через териминал Git ввести следующие команды:

    * *git remote add origin <ссылка на удалённый репозиторий>* //связывает локальный и удалённый репозитории;

   * *git branch -M main* // указывает, какая ветка будет являться основной;
   * *git push -u origin main* //отправляем то, что сделали локально на удалённый репозиторий.

   После ввода этих команд при первой отправке в новый репозиторий выйдет окно с авторизацией. Необходимо её пройти.



### **Как организовать совместную работу на GitHub.com**
___
1. Предоставить партнёру/коллеге ссылку из удалённого репозитория (зелёная кнопка "Code").
2. Коллега скачивает его со своего ПК с помощью команды *git clone <ссылка>*.
3. Вносит изменения локально на своём ПК, используя стандартные программы.
4. Чтобы эти изменения отобразились на удалённом репозитории, нужно ввести команду *git push*.

*(Также можно вносить изменения и на удалённом репозитории в GitHub, внося информацию об изменениях в поле "Commit").*

5. Другой пользователь, чтобы подтянуть к себе изменения, локально вводит команду *git pull* (эта команда не только подтягивает всю информацию, но и выполняет слияние как команда *git merge*, предлагая разрешить конфликты).

***
Инструкция составлена на основе материала, размещенного по [ссылке.](https://github.com/oleggolen/Seminar-13-12-2021#readme)