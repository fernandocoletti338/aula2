﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosInformacoaGeradasPeloProfessor
{
    class ControleDeCarros
    {
        Carros = new List<Carros>
    
    /*{

     1	Risus Company	 7,200	18	29/01/2019
     2	Risus Associates	 9,961	4	10/02/2019
     3	Et Libero Proin Foundation	 8,710	17	24/01/2019
     4	Cursus Et Ltd	 9,010	17	26/10/2019
     5	Odio Etiam Ligula Company	 5,245	8	16/02/2019
     6	Eu Nibh Inc.     7,922	9	27/06/2019
     7	Tellus Limited	 7,294	7	26/01/2019
     8	Imperdiet PC	 8,305	5	06/09/2019
     9	Elit Inc.    5,398	18	09/06/2019
     10	Quam A Limited   5,398	14	09/09/2019
     11	Adipiscing Institute	 8,133	4	24/10/2019
     12	Posuere At Velit Ltd	 5,121	15	19/11/2019
     13	Nunc In Industries   8,902	2	21/07/2019
     14	Integer Vitae Nibh Corporation	 6,313	20	02/02/2019
     15	Tellus Nunc Lectus Company	 9,650	2	20/07/2019
     16	Suspendisse LLC	 5,319	12	24/12/2019
     17	Mauris Vestibulum Corporation    5,790	5	14/11/2019
     18	Sed Nec Corp.    8,421	2	05/05/2019
     19	Enim Nisl Elementum Inc.	 5,904	6	26/06/2019
     20	Ac Mattis Semper Corporation	 5,110	4	14/01/2019
     21	Donec Tempus Lorem LLC	 8,576	16	29/03/2019
     22	Tempor Augue Ac Ltd	 9,072	16	09/07/2019
     23	Diam Duis Mi LLC	 8,472	4	23/09/2019
     24	Aliquam Corp.	 6,607	4	28/09/2019
     25	Montes Institute	 6,176	8	19/06/2019
     26	Hendrerit Institute	 8,387	11	17/09/2019
     27	Erat Etiam Vestibulum Corporation	 7,584	9	02/06/2019
     28	Adipiscing Ltd	 7,887	9	19/03/2019
     29	In Tempus Eu Inc.	 5,233	16	20/07/2019
     30	Elit Institute	 7,359	11	12/09/2019
     31	Aliquam Erat LLC     8,842	4	14/03/2019
     32	A Feugiat Tellus PC	 9,176	4	10/12/2019
     33	Aliquet Incorporated	 9,057	8	26/04/2019
     34	Dolor Dolor Tempus Institute	 8,433	15	31/10/2019
     35	Risus Odio Auctor PC	 8,286	11	29/03/2019
     36	Aliquet Molestie Tellus Corp.	 8,779	1	05/07/2019
     37	Ipsum Corp.	 5,568	15	10/03/2019
     38	Mi Lacinia Foundation    7,442	20	09/07/2019
     39	Cubilia Curae; Corp.     8,421	7	26/05/2019
     40	Velit Sed Malesuada Associates	 9,841	6	07/11/2019
     41	Duis Foundation	 9,849	6	08/12/2019
     42	Erat Semper Consulting	 6,168	10	10/11/2019
     43	Turpis Inc.  7,758	7	12/08/2019
     44	Aenean Industries	 8,770	12	10/09/2019
     45	Nulla Industries	 8,884	8	10/11/2019
     46	Semper Egestas Urna Inc.	 9,428	11	26/06/2019
     47	Donec Luctus Aliquet Industries	 5,928	8	11/07/2019
     48	Cum Sociis Natoque Foundation	 7,506	2	21/07/2019
     49	Vitae Sodales Limited    8,912	8	22/06/2019
     50	Tellus Sem Mollis Ltd	 9,615	20	30/10/2019
     51	Nulla Tincidunt LLC  5,562	19	22/09/2019
     52	Sed Dictum Institute     9,243	14	26/06/2019
     53	Sed Turpis Company   7,243	14	20/08/2019
     54	Vitae Diam Proin Associates	 6,631	2	10/06/2019
     55	Curabitur Inc.	 8,090	3	09/02/2019
     56	Suscipit Est Ac LLC	 8,567	15	08/03/2019
     57	Neque Morbi Industries   5,171	1	03/10/2019
     58	Non Ltd	 5,102	19	14/08/2019
     59	Arcu Vestibulum Ante Institute	 6,128	1	08/10/2019
     60	Nulla Foundation	 7,636	6	14/04/2019
     61	Quis Massa Mauris LLP	 5,053	3	09/10/2019
     62	Ut Incorporated	 6,922	17	16/09/2019
     63	Aenean Egestas Corp.     8,142	19	17/11/2019
     64	Fusce Mi Lorem Consulting	 8,312	20	19/11/2019
     65	A Sollicitudin Orci PC	 5,864	1	20/03/2019
     66	Sociosqu Limited	 5,985	12	28/11/2019
     67	Ullamcorper Duis Cursus LLC	 5,164	7	22/12/2019
     68	Nibh Lacinia LLC     7,760	10	13/06/2019
     69	Eu Dui Institute     7,695	8	12/12/2019
     70	Fringilla Purus Mauris Consulting	 5,845	6	01/03/2019
     71	Donec Tempus Lorem Industries	 8,472	19	09/03/2019
     72	Auctor Incorporated	 6,795	1	04/10/2019
     73	Enim Etiam Imperdiet Corporation	 6,532	13	14/10/2019
     74	Non Cursus Non Industries	 9,569	16	25/10/2019
     75	Ut Semper Incorporated   5,760	18	14/01/2019
     76	Sed Malesuada Corporation    6,561	4	06/03/2019
     77	Sed Neque Consulting     7,308	2	31/08/2019
     78	Nisl Arcu PC     7,260	8	19/06/2019
     79	Euismod Est Consulting   6,020	11	27/10/2019
     80	Leo Vivamus Ltd  5,055	8	22/10/2019
     81	Tristique Neque Inc.     9,268	13	25/02/2019
     82	In Lobortis PC   5,539	4	18/12/2019
     83	Nunc Ltd	 6,846	2	09/10/2019
     84	Dictum Proin Limited     5,543	12	05/10/2019
     85	Erat Vitae LLP   5,060	7	12/12/2019
     86	Pellentesque Ultricies Dignissim PC	 7,971	15	25/10/2019
     87	Phasellus Elit Company   5,350	15	31/10/2019
     88	Luctus Felis Ltd     9,872	13	06/01/2019
     89	Dui Suspendisse PC   6,878	7	06/02/2019
     90	Odio Associates	 7,636	18	24/07/2019
     91	Vel Company	 7,410	5	16/02/2019
     92	Lobortis Institute	 5,110	8	27/05/2019
     93	Scelerisque Company	 7,983	19	03/12/2019
     94	Posuere Enim Company     6,968	19	22/04/2019
     95	Sem Ut Corp.     6,504	11	02/02/2019
     96	Dui Fusce Aliquam PC	 7,837	2	08/12/2019
     97	Nisl Sem Industries  6,835	5	14/11/2019
     98	Vitae Corp.	 7,669	7	09/11/2019
     99	Malesuada Incorporated	 5,960	4	26/09/2019
     100	Mauris Ltd	 8,974	18	16/05/2019*/

}
}
