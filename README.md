# git_seminars

## Akmal199872

Что такое Git?
Git - это одна из реализаций распределённых систем контроля версий, имеющая как и локальные, так и удалённые репозитории. Является самой популярной реализацией систем контроля версий в мире.

Подготовка репозитория
Для создание репозитория необходимо выполнить команду git init в папке с репозиторием и у Вас создаться репозиторий (появится скрытая папка .git)

Создание коммитов
Git add
Для добавления измений в коммит используется команда git add. Чтобы использовать команду git add напишите git add <имя файла>

Просмотр состояния репозитория
Для того, чтобы посмотреть состояние репозитория используется команда git status. Для этого необходимо в папке с репозиторием написать git status, и Вы увидите были ли измения в файлах, или их не было.

Создание коммитов
Для того, чтобы создать коммит(сохранение) необходимо выполнить команду git commit. Выполняется она так: git commit -m "<сообщение к коммиту>. Все файлы для коммита должны быть ДОБАВЛЕНЫ и сообщение к коммиту писать ОБЯЗАТЕЛЬНО.

Перемещение между сохранениями
Для того, чтобы перемещаться между коммитами, используется команда git checkout. Используется она в папке с пепозиторием следующим образом: git checkout <номер коммита>

Журнал изменений
Для того, чтобы посмтреть все сделанные изменения в репозитории, используется команда git log. Для этого достаточно выполнить команду git log в папке с репозиторием

Ветки в Git
Создание ветки
Для того, чтобы создать ветку, используется команда git branch. Делается это следующим образом в папке с репозиторием: git branch <название новой ветки>

Слияние веток
Для того чтобы дабавить ветку в текущую ветку используется команда git merge

Удаление веток
Для удаления ветки ввести команду "git branch -d 'name branch'"

##Добавочная информация от Akmal199872 Существует список команд, которые активно используются в данном ПО:

git help # справка по всем командам git clone git status git branch git checkout git merge git remote git fetch git push git pull

##Данная запись выполнена из branch_2

##Данная запись выполнена из branch_3

##Запись для конфликта ##Данная запись выполнена из branch_4 ##Конфликтная запись из branch_3 для branch_4 ##Конфликтная запись из branch_3 для branch_4 ##Конфликтная запись из branch_3 для branch_4

Данная запись выполнена из другого компьютера. Целью записи является продемонстрировать изменение через **pull request** команду


## Дополнительная информация о работе с удалёнными репозиториями Git

Чтобы склонировать данные с удалённого репозитория на свой локальный, требуется ввести команду *git clone*

Если репозиторий уже склонирован и требуется синхронизировать данные из удалённого репозитория - поможет команда *git pull*

Когда мы внесли данные в локальный репозиторий и хотим их отправить на Github - здесь участвует команда *git push*
