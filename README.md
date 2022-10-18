# Инструкция для работы с git и удаленными репозиториями

## Что такое Git?
Git- это одна из реализаций распределенных систем контроля версий, имеющая как илокальные так и удалённые репозитарии
## Подготовка репозитария
Для создания репозитария необходимо выполнить команду *git init* в папке с репозитарием и у Вас создатся репозитарий (появиться скрытая папка .git)

## Создание коммитов

### Git add
Для добавления изменений в коммит используется команда *git add*. Чтобы использовать команду *git add* напишите *git add <имя файла>*

### Просмотр состояния репозитория
Для того, чтобы посмотреть состояние репозитория используется команда *git status*. Для этого необходимо в папке с репозиторием написать *git status*, и Вы увидите были ли изменения в файлах, или их не было.

### Создание коммитов
для того чтобы создать коммит (сохранение) необходимо выполнить команду *git commit*. Выполняется она так: *git commit* -m <"сообщение к коммиту">. Все файлы для коммита должны быть ***ДОБАВЛЕНЫ*** и сообщение к коммиту писать ***ОБЯЗАТЕЛБНО***.

## Перемещение между сохранениями
Для того чтобы перемещаться между коммитами, используется команда *git checkout*. Используется она в папке с репозитарием следующим образом: *git checkout <номер коммита>*.

## Журнал изменений
Для того, чтобы посмотреть все сделанные изменения в репозитории, используется команда *git log*. Для этого достаточно выполнить команду *git log* в папке с репозиторием.

## Ветки в Git 

### Создание ветки
Для того, чтобы создать ветку, используется команда *git branch*. Делается это следующим образом в папке с репозитарием: *git branch <название новой ветки>*.

## Слияние веток

Для того, чтобы добавить ветку в текущую ветку, используется команда *git merge <name branch>*.

## Удаление веток

Для удаления ветки ввести команду "git branch -d 'name branch'".

## Для того, чтобы начать работать с удаленными репозиториями, необходимо:
 
Add heading textAdd bold text, <Ctrl+b>Add italic text, <Ctrl+i>
Add a quote, <Ctrl+Shift+.>Add code, <Ctrl+e>Add a link, <Ctrl+k>
Add a bulleted list, <Ctrl+Shift+8>Add a numbered list, <Ctrl+Shift+7>Add a task list, <Ctrl+Shift+l>
Directly mention a user or team
Reference an issue, pull request, or discussion
Add saved reply
Leave a comment
Не выбран ни один файл
Attach files by dragging & dropping, selecting or pasting them.
Styling with Markdown is supported
1. Зарегистрироваться на сайте github.com
2. Найти нужный репозиторий
3. Сделать fork проекта
4. Ввести в терминале команду git clone
5. Сделать ветку для изменений.
6. Командой git push направить все изменения на github

## Заключение