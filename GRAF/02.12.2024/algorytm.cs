 Graf1 alogorytm()
        {
            var krawedzie = this.edges.OrderBy(k => k.weight).ToList();
            var listTmp = new List<Graf1>() { new Graf1(krawedzie[0]) }; // dodanie od razu krawędzi
            for (int i = 1; i < krawedzie.Count; i++) //przechodzenie po kolei po krawędziach
            {
                var k = krawedzie(i);
                int l = -1;

                for (int j=0; j<listTmp.Count; j++)
                {
                    var g = listTmp[j];
                    switch (g.ileNowychWezlow(k))
                    {
                        case 0: // pomiajamy krawędz
                            break;
                        case 1:
                            if (l < 0)
                            {
                                g.Add(k);
                                l = j;
                            }
                            else
                            {
                                listTmp[l].Join(g); // im not sure
                                listTmp.RemoveAt(j);
                                j = listTmp.Count;
                                break;
                            }
                        case 2:
                            listTmp.Add(new Graf1(k));
                            break;

                    }
                }
            }
            
        }
