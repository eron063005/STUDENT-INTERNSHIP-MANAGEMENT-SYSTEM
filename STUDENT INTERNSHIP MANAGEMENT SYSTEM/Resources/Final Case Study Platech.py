
# Platform Technology
# Final Case Study
# 
# BSIT - 2D 
# 
# MEMBERS:    
# Sam Aidan C. Gonzaga
# Aaron G. Cayabyab
# Vehniah P. Samson

import pandas as pd
import numpy as np
import matplotlib.pyplot as plt 


df = pd.read_csv(r"resources\VAIA_OJT_INFORMATION.csv")



# Get summary Statistics for numeric columns 
df.describe()


df.shape

df.isnull().sum()




df['StudentID'] = df['StudentID'].astype(str).str.extract(r'(\d+)').astype(int)
# Example: your data

# Mapping dictionary
rating_map = {
    'Outstanding': 5,   # Outstanding
    'Very Satisfactory': 4,  # Very Satisfactory
    'Satisfactory': 3,   # Satisfactory
    'Fair': 2,   # Fair
    'Unsatisfactory': 1    # Unsatisfactory
}

# Map text labels to numeric
df['Equivalent Rating'] = df['Equivalent Rating'].map(rating_map)





# In[292]:


# 5.Data Engineering / Pre-processing
#Convert, normalize, or encode your features before modeling

from sklearn.preprocessing import StandardScaler

start_idx = df.columns.get_loc("Attends regularly.")
cols = list(df.columns[start_idx: - 1])

print(cols)

# Standardize average score
scaler = StandardScaler()
df['Total Points Earned'] = scaler.fit_transform(df[['Total Points Earned']])

# Make class to float
df['Remark'] = df['Remark'].replace({'Passed': 1.0, 'Failed': 0.0}).astype(float)

print(df['Remark'].value_counts())


# In[293]:


# 6.Data Visualization
#Use charts to understand relationships and patterns:
# ----- Countplot -----
# plt.figure(figsize=(6,4))
df['Remark_label'] = df['Remark'].map({0.0: 'Failed', 1.0: 'Passed'})
ax = sns.countplot(x='Remark_label', data=df, palette="Set1")
plt.title("Number of Students by Remark", fontsize=14)
plt.xlabel("Remark")
plt.ylabel("Number of Students")

for p in ax.patches:
    height = int(p.get_height())
    ax.text(p.get_x() + p.get_width()/2, height/2, str(height), ha='center', va='center', color='white', fontsize=12, fontweight='bold')
plt.ioff()  # turn off interactive mode
# Save figure
plt.savefig("resources/countplot.png")
plt.close()  # close the plot so it doesn't display interactively

# In[294]:


# 7. Data Splitting (Training and Testing Set)
# Separate your data into training and testing portions:

from sklearn.model_selection import train_test_split

# Features: the columns that influence the target
X = df[cols]

# Target: what you want to predict
y = df['Remark'] 

# Split the data: 80% training, 20% testing

X_train, X_test, y_train, y_test = train_test_split(
    X, y, test_size=0.3, stratify=y, random_state=42
)


from sklearn.tree import DecisionTreeClassifier

# Create the model
model = DecisionTreeClassifier(random_state=42)

# Train the model
model.fit(X_train, y_train)

# Print training accuracy
train_acc = model.score(X_train, y_train)
print("Training Accuracy:", train_acc)



y_predict= model.predict(X_test)
print(y_predict)

error=y_predict - y_test
error
print(X_test)



import matplotlib.pyplot as plt
import seaborn as sns
from sklearn.metrics import confusion_matrix


# ----- Confusion Matrix -----
from sklearn.metrics import confusion_matrix
cm = confusion_matrix(y_test, y_predict)

# plt.figure(figsize=(6,4))
sns.heatmap(cm, annot=True, fmt='d', cmap='Blues', xticklabels=['Failed','Passed'], yticklabels=['Failed','Passed'])
plt.xlabel("Predicted")
plt.ylabel("Actual")
plt.title("Confusion Matrix")
plt.ioff()  # turn off interactive mode
plt.savefig("resources/confusion_matrix.png")
plt.close()



# In[298]:


# 11. Performance Metrics

from sklearn.metrics import accuracy_score, confusion_matrix

# Predict on test set
y_pred = model.predict(X_test)

# 1. Accuracy
acc = accuracy_score(y_test, y_pred)
print("Accuracy:", acc)

cm = confusion_matrix(y_test, y_pred)
print("\nConfusion Matrix:\n", cm)

