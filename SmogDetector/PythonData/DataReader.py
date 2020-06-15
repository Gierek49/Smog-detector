#!/usr/bin/env python
# coding: utf-8

# In[1]:


import pandas as pd
import numpy as np


# In[2]:


api = pd.read_json('http://api.gios.gov.pl/pjp-api/rest/station/findAll')

api.to_csv('Data.csv',index=False)

dft=pd.read_csv('Data.csv')

df=dft[['id', 'stationName', 'gegrLat', 'gegrLon']]

v = df['id'].count()

tid= pd.Series([],dtype=int)

tid=df['id']

Type_new = pd.Series([],dtype=str)

v


# In[3]:


def take_polution(id):
    return pd.read_json('http://api.gios.gov.pl/pjp-api/rest/aqindex/getIndex/'+str(id) )


for x in range(0,v):
    t = str(tid[x])
    w = take_polution(t)
    Type_new[x]=w['stIndexLevel'].indexLevelName 


# In[4]:


df.insert(4, "NameLevel", Type_new)


# In[6]:


#Tutaj zmienić scieżkę gdzie bedzie to zapisywane w razie potrzeby 
df.to_csv('PolutionLevel.csv',index=False)

