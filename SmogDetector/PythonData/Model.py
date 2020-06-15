#!/usr/bin/env python
# coding: utf-8

# In[ ]:


import pandas as pd
import numpy as np
import sys

from sklearn.neighbors import KNeighborsClassifier
#from sklearn.model_selection import cross_val_score

#get_ipython().run_line_magic('matplotlib', 'inline')


# In[ ]:


minLat =49
maxLat=54.50
minLng =14.07
maxLng=24.08


# In[ ]:


#Tutaj zmienić jak coś scieżke do pliku
df = pd.read_csv('PolutionLevel.csv')


# In[ ]:


X=df[['gegrLat','gegrLon']]

y=df['NameLevel'] 

n=15

model= KNeighborsClassifier(n_neighbors=n,weights='distance')
model.fit(X,y)

lat=np.arange(minLat, maxLat, 0.1)
lng= np.arange(minLng,maxLng,0.1)

d=np.zeros([1,2],float)


# In[ ]:


dataX=float(sys.argv[1])      
dataY=float(sys.argv[2])

d[0][0]=dataX
d[0][1]=dataY

print(model.predict(d))        

