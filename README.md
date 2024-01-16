# NanoSurvey
API ������� ������-�������

## Route
### GET /GetQuestion?surveyId=\{id\} ���� /GetQuestion?pageIndex=\{pageId\}&surveyId=\{id\}
��������� ������ ������� ��� ����������� �� ������

������ ������:
```
{
    "questionItem": {
        "answers": [
            {
                "questionId": 1,
                "text": "�������� �����",
                "value": null
            },
            {
                "questionId": 1,
                "text": null,
                "value": 5
            }
        ],
        "surveyId": 1,
        "text": "�������� ������"
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

### POST /GetQuestion?surveyId=\{id\} ���� /GetQuestion?pageIndex=\{pageId\}&surveyId=\{id\}

���������� ����������� ������ �� ������ �� ������ ������. ��������� ��������� ������������.

������ �������:
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

������ ������:
```
{
    "questionItem": {
        "answers": [
            {
                "questionId": 1,
                "text": "�������� �����2",
                "value": null
            },
            {
                "questionId": 1,
                "text": null,
                "value": 5
            }
        ],
        "surveyId": 1,
        "text": "�������� ������2"
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

��� ������ ������� ����������, ��� �������� ������� �������� � ��������� ������.

**����������.** ���� ��� ����� ������� ����� �������� � �����, �� ������ ������������ ��� �������:

```
Add-Migration -Name SurveyMigration -Context SurveyContext -Project DataAccess -StartupProject Web
```