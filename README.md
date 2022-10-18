<a id="anchor"></a>

# Инструкция для работы с Git и удалёнными репозиториями

## Что такое Git? ![Изображения логотипа Git](logo.jpeg)
Git - это одна из реализаций распределённых систем контроля версий, имеющая как и локальные, так и удалённые репозитории. Является самой популярной реализацией систем контроля версий в мире.

Скачать установщик Git (https://git-scm.com/download/win)
## Подготовка репозитория
Для создание репозитория необходимо выполнить команду <span style="color:blue">*git init*</span>.  в папке с репозиторием и у Вас создаться репозиторий (появится скрытая папка ```.git```)

## Создание коммитов

### 1) Git add
Для добавления измений в коммит используется команда <span style="color:blue">*git add*</span>. Чтобы использовать команду *git add* напишите
```
git add <имя файла>
```
### 2) Просмотр состояния репозитория
Для того, чтобы посмотреть состояние репозитория используется команда <span style="color:blue">*git status*</span>. Для этого необходимо в папке с репозиторием написать <span style="color:blue">*git status*</span>, и Вы увидите были ли измения в файлах, или их не было.

### 3)Создание коммитов
Для того, чтобы создать коммит(сохранение) необходимо выполнить команду *git commit*. Выполняется она так: <span style="color:blue">*git commit -m "<сообщение к коммиту>*</span>. Все файлы для коммита должны быть ***ДОБАВЛЕНЫ*** и сообщение к коммиту писать ***ОБЯЗАТЕЛЬНО***.
## Журнал изменений
Для того, чтобы посмтреть все сделанные изменения в репозитории, используется команда <span style="color:blue">*git log*</span>. Для этого достаточно выполнить команду <span style="color:blue">*git log*</span> в папке с репозиторием

## Перемещение между сохранениями
Для того, чтобы перемещаться между коммитами, используется команда <span style="color:blue">*git checkout*</span>. Используется она в папке с пепозиторием следующим образом: <span style="color:blue">*git checkout <номер коммита>*</span>.  Номер коммита определяется командой <span style="color:blue">*git log*</span> где для перемещения между сохранениями используются первые 4 символа.

![Скриншот по перемещению между сохранениями](git_log.png)
## Ветки в Git

### Создание ветки

Для того, чтобы создать ветку, используется команда <span style="color:blue">*git branch*</span>. Делается это следующим образом в папке с репозиторием: <span style="color:blue">*git branch <название новой ветки>*</span>

## Слияние веток

Для того чтобы дабавить ветку в текущую ветку используется команда <span style="color:blue">*git merge <name branch>*
## Удаление веток
Для удаления ветки ввести команду <span style="color:blue">"git branch -d 'name branch'"</span>
________________________________________________________________________
>Полезные советы от Ковальского Яна
>> Для упрощения взаимодействия с Visual Studio Code предоставлю вашему обозрению несколько HotKeys.
    >>>Ctrl+` (Тильда, [~], [Ё]) - открытие Терминала.
    >>>>Ctrl+S - сохранение файла.


#Делимся подборкой ресурсов, где можно учиться работать в Git.
1.[Бесплатная книга Pro Git](https://git-scm.com/book/en/v2) официальном сайте Git.

2.Бесплатный онлайн-курс [на английском](https://githowto.com/) и [на русском языке](https://githowto.com/ru).

3.Интерактивный-визуальный [онлайн-тренажёр по Git](https://learngitbranching.js.org/?locale=ru_RU).

#GitHub - начальная настройка и работа с удаленными репозиториями

Разработчики программ используют в работе различные платформы для обмена исходным кодом, его хранения и распространения. Одной из таких платформ является GitHub. Она настолько популярна, что ее мощностями пользуются даже такие «монстры», как Microsoft и RedHat. Инструментарий платформы включает возможности просмотра кода, а также его распространения с документацией и релизами.

###Гитхаб - GitHub

Веб-сервис GitHub востребован для хостинга IT-проектов и совместной разработки. Разработчики системы называют ее «социальной сетью» для программистов. Здесь они объединяют репозитории, комментируют примеры «чужого» кода и используют платформу в качестве облачного хранилища с возможностью быстрой передачи заказчику.

### 1) Создание аккаунта в Github
Первый шаг к использованию сервиса GitHub заключается в регистрации нового пользователя. В процедуре нет ничего сложного – достаточно зайти на [официальный сайт](https://github.com/) и создать новую учетную запись. Система запросит **рабочую электронную почту**.

Пароль вводится на выбор пользователя, но с учетом правил. Так, рекомендуется комбинация размером в 15 символов или 8, но с использованием хотя бы одной цифры и строчной буквы. Имя пользователя, как и email, проверяется на занятость, и придется выбирать тот, с которым платформа позволит продолжать регистрацию.

Далее нужно указать, хочется ли получать новости об обновлениях продуктов и самой системы. Последним шагом становится подтверждение – пользователю предлагается собрать паззл, после чего станет активной кнопка «**Зарегистрироваться**».

Вход на платформу будет открыт только после подтверждения электронной почты, поэтому зайти анонимно не получится. Это своеобразная защита сервера от многочисленных ботов и гарантия для пользователей, что они будут общаться с реальными людьми. Теперь можно приступать к управлению настройками внутри личного кабинета.

### 2) Создание репозитория
Важно отметить, что сервис англоязычный, и пользоваться им без знания языка получится только при использовании обновленных версий браузеров типа Google Chrome, где есть встроенные функции по переводу страниц. В любом случае работа начинается с создания собственного репозитория – в бесплатном режиме доступны публичные, частные откроются только при активации платного тарифа.

#### Последовательность действий:

1)Нажать на кнопку «**Start a project**».
2) Ввести название и описание репозитория.
3) Поставить галочку на «**Initialize this repository with a README**».
4) Выбрать нужный тип лицензии и нажать на кнопку «**Create project**».

Тип лицензии (приватная или публичная) допускается заменить после, в процессе использования платформы. Единственная настройка, которую пользователи делают сразу, – это создание нескольких веток для размещения разных проектов. Например, для тестового кода и финальных релизов, чтобы не путать их при разработке и общении с другими кодерами.

Подобный подход часто используют создатели продуктов, которыми пользуются «массы». Им передается ссылка на проверенные стабильные версии, в то время как команда продолжает работу над таким же комплектом файлов без опасения нарушить функциональность системы в целом. При использовании платформы следует ориентироваться на отметку «**Branch**».

Данная отметка обозначает текущую ветку. Создание новой инициируется просто – достаточно в списке начать набирать еще несуществующее название, и система выдаст сообщение «Create branch». Сразу после этого пользователь перекидывается в новую ветку (это стоит учитывать при работе, чтобы случайно не начать редактирование «не тех файлов»).

### 3) Изменение файлов и коммиты
Корректировка файлов на GitHub выполняется при помощи коммитов. Это непосредственно само исправление и краткое описание изменений. Такой подход позволяет «**внешним**» пользователям ориентироваться в нововведениях кода и упрощает контроль командной работы, когда один и тот же файл может редактироваться разными исполнителями.

Система сохранения информации о корректировках удобна, когда они вносятся в различные участки кода, но связаны с определенной задачей. Фактически текстовый файл с описанием «связывает» разрозненные изменения и объясняет непосвященному программисту их суть, назначение. Чтобы запустить редактирование **README**, нужно в правой панели нажать на «**кисточку**».

После этого откроется текстовый редактор, где вносятся исправления. По завершении заполняется поле «**Commit**» внизу страницы (кратко, что изменилось) и нажимается кнопка «**Commit changes**». Сохраненные корректировки будут внесены в текущую (активную) ветку проекта, поэтому перед их внесением следует убедиться в правильном выборе.

### 4) Чтобы запушить ветку в онлайн-репозиторий введем команду:


```git push --set-upstream origin YKs``` **(YKs - name_branch)**

Открываем репозиторий в GitHub и видим, что добавилась ветка ```YKs```:

### 5) Создание запросов слияния (Pull Request) в Github
При подключении к работе сторонних специалистов может понадобиться функция запроса слияния (**Pull Request**). Инструмент для работы в таком формате называется **DIFF**. Он подчеркивает любые «**чужие**» изменения, чтобы владелец программы сразу видел, где код писал не он. Пометки будут доступны только после создания коммита.

Последовательность действий:

1) Открыть вкладку «**Pull Request**».
2) Нажать на кнопку «**Create Pull Request**».
3) Выбрать ветку, которую следует слить с основной.
4) Просмотреть внесенные кодером изменения.
5) После изучения информации созданный запрос на слияние подтверждается нажатием «**Merge Pull Request**». Новый код будет импортирован в основную ветку, а созданная сторонним исполнителем может спокойно удаляться.

### 6) Отчеты об ошибках
Платформа GitHub используется не только для совместной разработки, а еще и для получения обратной связи с пользователями продуктов. Так, на вкладке «**Issue**» любой «**тестировщик**» может оставить сообщение о проблемах, с которыми ему пришлось столкнуться при использовании ПО. Чтобы сделать это, нужно нажать кнопку «**New issue**».

После этого вносится заголовок и текст сообщения. «**Проблема**» отправляется нажатием на кнопку «**Create new issue**». Владелец ветки получает уведомления в личном кабинете или на электронную почту, указанную при регистрации.

### 7) Заключение
Финалом разработки обычно становится выпуск определенного релиза программного продукта. Это отражается на вкладке «**Releases**». Здесь следует нажать на кнопку «**Create New Release**», указать номер версии в поле «**Tag Version**», внести ее название и небольшое описание. Здесь же прикрепляются архивы с компилированными файлами.

Остается нажать на «**Create Release**» и убедиться в публикации релиза. Ссылки на исходный код в tar.gz и zip создаются автоматически. Остальные файлы понадобится добавлять вручную.


[Вверх](#anchor)
