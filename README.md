# NanoSurvey
API системы онлайн-опросов

## Route
### GET /GetQuestion?surveyId=\{id\} либо /GetQuestion?pageIndex=\{pageId\}&surveyId=\{id\}
Получение данных вопроса для отображения на фронте

Пример ответа:
```
{
    "questionItem": {
        "answers": [
            {
                "questionId": 1,
                "text": "Тестовый ответ",
                "value": null
            },
            {
                "questionId": 1,
                "text": null,
                "value": 5
            }
        ],
        "surveyId": 1,
        "text": "Тестовый вопрос"
    },
    "surveyId": 1,
    "paginationInfo": {
        "totalItems": 3,
        "actualPage": 0,
        "nextButtonDisabled": "",
        "endButtonDisabled": "true"
    }
}
```

### POST /PostAnswers

Сохранение результатов ответа на вопрос по кнопке “Далее”. Принимает выбранные радиобаттоны.

Пример запроса:
```
{
    "pageIndex": 0,
    "surveyId": 1,
    "questionId": 1,
    "answersId": [
        1
    ]
}
```

Пример ответа:
```
{
    "questionItem": {
        "answers": [
            {
                "questionId": 1,
                "text": "Тестовый ответ2",
                "value": null
            },
            {
                "questionId": 1,
                "text": null,
                "value": 5
            }
        ],
        "surveyId": 1,
        "text": "Тестовый вопрос2"
    },
    "surveyId": 1,
    "paginationInfo": {
        "totalItems": 3,
        "actualPage": 1,
        "nextButtonDisabled": "",
        "endButtonDisabled": "true"
    }
}
```

При первом запуске приложения, оно заполнит примеры вопросов с примерами ответа.

**Примечание.** Если вам нужно создать новую миграцию с базой, вы можете использовать эту команду:

```
Add-Migration -Name SurveyMigration -Context SurveyContext -Project DataAccess -StartupProject Web
```
