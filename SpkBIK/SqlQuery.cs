using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpkBIK
{
    class SqlQuery
    {
        /// <summary>
        /// Запрос данных для вывода в таблицу справочника
        /// </summary>
        public static string strSqlQuerySelect = @"
SELECT 
BNKSEEK.VKEY, 
BNKSEEK.REAL,
PZN.NAME as PZN,
UER.UERNAME as UER,
REG.NAME AS RGN,
BNKSEEK.IND,
TNP.FULLNAME AS TNP,
BNKSEEK.NNP,
BNKSEEK.ADR,
BNKSEEK.RKC,
BNKSEEK.NAMEP,
BNKSEEK.NEWNUM,
BNKSEEK.TELEF,
BNKSEEK.REGN,
BNKSEEK.OKPO,
BNKSEEK.DT_IZM,
BNKSEEK.KSNP,
BNKSEEK.DATE_IN,
BNKSEEK.DATE_CH
            FROM (((BNKSEEK
LEFT JOIN TNP
    ON TNP.TNP = BNKSEEK.TNP)
LEFT JOIN PZN
    ON PZN.PZN = BNKSEEK.PZN)
LEFT JOIN UER
    ON UER.UER = BNKSEEK.UER)
LEFT JOIN REG
    ON REG.RGN = BNKSEEK.RGN
WHERE 
(BNKSEEK.NEWNUM = @strBIC OR @strBIC IS NULL) 
AND
(LCASE(REG.NAME) LIKE LCASE('%' + @strREG +'%') OR @strREG IS NULL) 
AND
(PZN.VKEY = @strPZN OR @strPZN = 0) 
";

        /// <summary>
        /// Запрос получения данных по определенной записи в справочнике (по идентификатору)
        /// </summary>
        public static string strSqlQuerySelectRecord = @"
SELECT 
BNKSEEK.REAL,
(SELECT PZN.VKEY FROM PZN WHERE PZN.PZN = BNKSEEK.PZN)  AS PZN,
(SELECT UER.VKEY FROM UER WHERE UER.UER = BNKSEEK.UER) AS UER,
(SELECT REG.VKEY FROM REG WHERE REG.RGN = BNKSEEK.RGN) AS  RGN,
BNKSEEK.IND,
(SELECT TNP.VKEY FROM TNP WHERE TNP.TNP = BNKSEEK.TNP) AS TNP,
BNKSEEK.NNP,
BNKSEEK.ADR,
BNKSEEK.RKC,
BNKSEEK.NAMEP,
BNKSEEK.NEWNUM,
BNKSEEK.TELEF,
BNKSEEK.REGN,
BNKSEEK.OKPO,
BNKSEEK.DT_IZM,
BNKSEEK.KSNP,
BNKSEEK.DATE_IN,
BNKSEEK.DATE_CH
    FROM BNKSEEK
WHERE 
    BNKSEEK.VKEY = @strVKEY
";

        /// <summary>
        /// Запрос данных Тип участника расчетов
        /// </summary>
        public static string strSqlQuerySelectPZN = @"
SELECT
PZN.VKEY AS ID,
PZN.NAME AS NAME
FROM PZN
ORDER BY 2
";

        /// <summary>
        /// Запрос данных Тип населенного пункта
        /// </summary>
        public static string strSqlQuerySelectTNP = @"
SELECT
TNP.VKEY AS ID,
TNP.FULLNAME AS NAME
FROM TNP
ORDER BY 2
";

        
        /// <summary>
        /// Запрос данных Тип участника системы электронных расчетов 
        /// </summary>
        public static string strSqlQuerySelectUER = @"
SELECT
UER.VKEY AS ID,
UER.UERNAME AS NAME
FROM UER
ORDER BY 2
";
   
        /// <summary>
        /// Запрос данных Территория Российской Федерации
        /// </summary>
        public static string strSqlQuerySelectRGN = @"
SELECT
REG.VKEY AS ID,
REG.NAME AS NAME
FROM REG
ORDER BY 2
";
        /// <summary>
        /// Запрос Обновление записи в таблице
        /// </summary>
        public static string strSqlQueryUpdateData = @"

UPDATE BNKSEEK
SET 
BNKSEEK.REAL = '' + @strREAL + '',
BNKSEEK.ADR = '' + @strADR + '',
BNKSEEK.NAMEP = '' + @strNAMEp + '',
BNKSEEK.TELEF = '' + @strTELEF + '',
BNKSEEK.REGN = '' + @strREGN + '',
BNKSEEK.NEWNUM = '' + @strNEWNUM + '',
BNKSEEK.OKPO = '' + @strOKPO + '',
BNKSEEK.KSNP = '' + @strKSNP + '',
BNKSEEK.NNP = '' + @strNNP + '',
BNKSEEK.DT_IZM = '' + @strDTIZM + '',
BNKSEEK.DATE_IN = '' + @strDATEIN + '',
BNKSEEK.DATE_CH = '' + @strDATECH + '',
BNKSEEK.PZN = '' + @strPZN + '',
BNKSEEK.UER = '' + @strUER + '',
BNKSEEK.TNP = '' + @strTNP + '',
BNKSEEK.RGN = '' + @strRGN + '',
BNKSEEK.IND = '' + @strIND + ''
WHERE BNKSEEK.VKEY = '' + @strVKEY + '' 
";

        /// <summary>
        /// Запрос выборка значения PZN по первичному ключу 
        /// </summary>
        public static string strSqlQuerySelectVkeyPZN = @"
SELECT
PZN.PZN
FROM PZN WHERE PZN.VKEY = @strPZN
";
        
        /// <summary>
        /// Запрос выборка значения UER по первичному ключу 
        /// </summary>
        public static string strSqlQuerySelectVkeyUER = @"
SELECT
UER.UER
FROM UER WHERE UER.VKEY = @strUER
";

        /// <summary>
        /// Запрос выборка значения TNP по первичному ключу 
        /// </summary>
        public static string strSqlQuerySelectVkeyTNP = @"
SELECT
TNP.TNP
FROM TNP WHERE TNP.VKEY = @strTNP
";

        /// <summary>
        /// Запрос выборка значения RGN по первичному ключу 
        /// </summary>
        public static string strSqlQuerySelectVkeyRGN = @"
SELECT
REG.RGN
FROM REG WHERE REG.VKEY = @strRGN
";

    
    /// <summary>
    /// Запрос Удаление записи из таблицы
    /// </summary>
    public static string strSqlQueryDeleteData = @"
DELETE FROM BNKSEEK
WHERE BNKSEEK.VKEY = '' + @strVKEY + ''
";

        /// <summary>
        /// Запрос Добавление записи в таблицу
        /// </summary>
    public static string strSqlQueryInsertData = @"
INSERT INTO BNKSEEK
( 
    [REAL],
    [ADR],    
    [NAMEP],
    [TELEF],
    [REGN],
    [NEWNUM],
    [OKPO],
    [KSNP],
    [NNP],
    [DT_IZM],
    [DATE_IN], 
    [DATE_CH], 
    [PZN],
    [UER],
    [TNP], 
    [RGN], 
    [IND],
    [VKEY],
    [NAMEN],
    [SROK]
)
VALUES
(   
    ?, 
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    ?,
    '0',
    '0'
)
";

 
        /// <summary>
        /// Запрос Проверка существования записи в таблице по БИКу для операции Update
        /// </summary>
    public static string strSqlQuerySelectUpd = @"
SELECT COUNT(BNKSEEK.VKEY) AS CN FROM BNKSEEK
WHERE BNKSEEK.NEWNUM = '' + @strNEWNUM + ''
AND BNKSEEK.VKEY <> '' + @strVKEY + ''
";

    /// <summary>
    /// Запрос Проверка существования записи в таблице по БИКу для операции Insert
    /// </summary>
    public static string strSqlQuerySelectIns = @"
SELECT COUNT(BNKSEEK.VKEY) AS CN FROM BNKSEEK
WHERE BNKSEEK.NEWNUM = '' + @strNEWNUM + ''
";

 }    
}

