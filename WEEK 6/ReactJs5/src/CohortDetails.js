import React from 'react';
import styles from './CohortDetailsmodule.css'; // fixed filename

// Reusable Cohort Box Component
function CohortDetails({ cohort }) {
  return (
    <div className={styles.box}>
      <h3 style={{ color: cohort.status === 'ongoing' ? 'green' : 'blue' }}>
        {cohort.name}
      </h3>
      <dl>
        <dt>Status</dt>
        <dd>{cohort.status}</dd>
        <dt>Start Date</dt>
        <dd>{cohort.startDate}</dd>
        <dt>Coach Name</dt>
        <dd>{cohort.coach}</dd>
        <dt>Trainer</dt>
        <dd>{cohort.trainer}</dd>
      </dl>
    </div>
  );
}

// Parent Component to Render All 3 Cohorts
function CohortList() {
  const cohorts = [
    {
      name: 'INTADMDF10 - .NET FSD',
      status: 'scheduled',
      startDate: '2025-08-01',
      coach: 'Aathma',
      trainer: 'Jojo Jose'
    },
    {
      name: 'ADM21JF014 - Java FSD',
      status: 'ongoing',
      startDate: '2025-07-01',
      coach: 'Apoorv',
      trainer: 'Elisa Smith'
    },
    {
      name: 'CDBJF21025 - Java FSD',
      status: 'ongoing',
      startDate: '2025-07-05',
      coach: 'Aathma',
      trainer: 'John Doe'
    }
  ];

  return (
    <div>
      {cohorts.map((cohort, index) => (
        <CohortDetails key={index} cohort={cohort} />
      ))}
    </div>
  );
}

export default CohortList;
