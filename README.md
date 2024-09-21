# Dynamics 365 FSCM AI Powered Product Translations 

A proof of concept that was entered into an internal Microsoft event called Hackathon.

This enhancement will use Microsoft AI to translate the name and description of your products to any languages you choose at the time they are released to your stores to be sold.

**Pre-requisites**
- A Dynamics FSCM environment
- Azure AI Studio

**There are 4 required parameters**

1. The AI endpoint Uri, typically in this format **https://my-aistudio.cognitiveservices.azure.com/**
2. The deployment you want to use
3. The secret key for the deployment (typically we'd use a key vault to store this but did not for the POC)
4. A comma separated list of language codes to translate the base language into.

![image.png](Images/image-5152fb5b-44b1-43b4-a0a1-c628a7960bf5.png)

Create a new or open and existing product.

![image.png](Images/image-939d6126-cc31-4540-a681-6ab49b811dba.png)

Click on the **Release products** button

![image.png](Images/image-c5181311-03df-4990-9faf-d943391ca86b.png)

Follow the prompts, click the **Finish** button

![image.png](Images/image-fae3301f-f424-4ec4-9571-c6b82e651d50.png)

Click on the Translations menu item

![image.png](Images/image-7ac3144c-2891-4a42-abdb-20982ac3f65d.png)
