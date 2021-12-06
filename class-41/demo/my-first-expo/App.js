import { StatusBar } from 'expo-status-bar';
import React, { useState, useEffect } from 'react';
import { StyleSheet, Button, Text, View, ScrollView } from 'react-native';
import * as Contacts from 'expo-contacts';

export default function App() {
  const [count, setCount] = useState(0);
  const [contacts, setContacts] = useState([]);
  const [contactsError, setContactsError] = useState(null);

  useEffect(() => {
    (async () => {
      const { status } = await Contacts.requestPermissionsAsync();
      if (status === 'granted') {
        const { data } = await Contacts.getContactsAsync({
          fields: [Contacts.Fields.Emails],
        });

        setContacts(data);
        if (data.length > 0) {
          const contact = data[0];
          console.log(contact);
        }
      }
      else {
        setContactsError("Could not load Contacts!");
      }
    })();
  }, []);

  return (
    <View style={styles.container}>
      <Text>Welcome to DeltaV</Text>

      <Text>You clicked {count} times</Text>
      <Button
        color='red'
        onPress={() => setCount(count + 1)}
        title="Click me!"
      />

      {contactsError ?
        <Text style={{ color: 'red', fontWeight: 'bold' }}>{contactsError}</Text> :
        <>
          <Text>Contact Count: {contacts.length}</Text>
          <ScrollView>
            {contacts.map((c, i) => (
              <Text key={i}>{c.lookupKey}</Text>
            ))}
          </ScrollView>
        </>
      }

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
